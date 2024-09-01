using Games.Model;
using Games.Repository.Interfaces;
using Games.Service.Interfaces;

namespace Games.Service
{
	public class GameService : IBaseService<Game>, IGameService
    {
        private IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

		public void Delete(int id)
		{
			try
			{
				Game? game = this.GetById(id);
				_gameRepository.Delete(game);
			}
			catch (Exception e)
			{
				throw;
			}
		}

		public Game? GetById(int id)
		{
			try
			{
				Game? returnGame = _gameRepository.Get(id);
				return returnGame;
			}
			catch (Exception e)
			{

				throw;
			}
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
                obj.Validate();
                
                if (obj.Id <= 0)
					obj.CreatedDate = DateTime.Now;

                obj.UpdatedDate = DateTime.Now;
                obj.IsActive = true;

                _gameRepository.Save(obj);
			}
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Validate(Game game) {
            
            if (game == null)
                throw new ArgumentNullException(nameof(game));

            if (string.IsNullOrEmpty(game.Name))
                throw new Exception("Game's name is empty");

        }

    }
}
