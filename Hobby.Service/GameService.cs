using FluentValidation.Results;
using Games.Model;
using Games.Repository.Interfaces;
using Games.Service.Interfaces;

namespace Games.Service
{
	public class GameService : IGameService
    {
        private IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

		public Game? GetById(int id)
		{
			Game? returnGame = _gameRepository.Get(id);
			return returnGame;
		}

		public void Remove(int id)
		{
			Game? game = this.GetById(id);
			_gameRepository.Delete(game);
		}

		public Game? GetByName(string? gameName)
		{
            if (gameName == null)
                throw new ArgumentNullException("Name is null");

            Game? gameReturn = null;
            gameReturn = _gameRepository.GetByName(gameName);
            return gameReturn;
		}

		public IList<Game> ListAll()
		{
			return _gameRepository.ListAll();
		}

		public void Save(Game obj)
        {
            try
            {
                ValidationResult validationResult = obj.Validate();
                
                if (obj.Id <= 0)
					obj.CreatedDate = DateTime.Now;

                obj.UpdatedDate = DateTime.Now;
                obj.IsActive = true;

                if(validationResult.IsValid)
					_gameRepository.Save(obj);
			}
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
