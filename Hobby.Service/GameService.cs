﻿using Games.Model;
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

		public void Delete(int? codObj)
		{
            try
            {
				if (!codObj.HasValue)
					throw new ArgumentNullException(nameof(codObj));

				Game? game = this.Get(codObj);

                _gameRepository.Delete(game);
			}
            catch (Exception e)
            {
                throw;
            }
		}

		public Game? Get(int? codObj)
        {
            try
            {
                if (!codObj.HasValue)
                    throw new ArgumentNullException(nameof(codObj));

				Game? returnGame = _gameRepository.Get(codObj.Value);

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

		public IList<Game> List()
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

                if (obj.Id <= 0)
                    _gameRepository.Add(obj);
                else
                    _gameRepository.Update(obj);
			}
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Update(Game obj)
        {
            throw new NotImplementedException();
        }

        public void Validate(Game game) {
            
            if (game == null)
                throw new ArgumentNullException(nameof(game));

            if (string.IsNullOrEmpty(game.Name))
                throw new Exception("Game's name is empty");

        }

    }
}
