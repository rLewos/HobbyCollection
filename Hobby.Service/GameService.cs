﻿using Games.Model;
using Games.Repository.Interfaces;
using Games.Service.Interfaces;

namespace Games.Service
{
    public class GameService : BaseService<Game>, IGameService
    {
        private IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public void Delete(Game obj)
        {
            throw new NotImplementedException();
        }

        public Game Get(int codObj)
        {
            throw new NotImplementedException();
        }

        public IList<Game> List()
        {
            return _gameRepository.ListAll();
        }

        public void Save(Game obj)
        {
            try
            {
                this.Validate(obj);
                if (obj.Id <= 0)
					obj.CreatedDate = DateTime.Now;

                obj.UpdatedDate = DateTime.Now;
                obj.IsActive = true;

                _gameRepository.Add(obj);
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
            if (game == null) {
                throw new ArgumentNullException(nameof(game));
            }

            if (string.IsNullOrEmpty(game.Name))
            {
                throw new Exception("Game's name is empty");
            }
        }


    }
}