using Games.Infraestructure;
using Games.Model;
using Games.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Games.Repository
{
	public class GameRepository : IGameRepository
	{
		private HobbyContext _context;

		public GameRepository(HobbyContext hobbyContext)
		{
			_context = hobbyContext;
		}

		public void Delete(Game? entity)
		{
			try
			{
				_context.Games.Remove(entity);
				_context.SaveChanges();
			}
			catch (Exception e)
			{

				throw;
			}
		}

		public Game? Get(int id)
		{
			return _context.Games.SingleOrDefault(g => g.Id == id);
		}

		public Game? GetByName(string gameName)
		{
			return _context.Games.SingleOrDefault(g => g.Name == gameName);
		}

		public IList<Game> ListAll()
		{
			return _context.Games.ToList();
		}

		public IList<Game> ListByUserId(string userId)
		{
			IList<Game> games =_context.UserGame.Where(ug => string.Equals(ug.User.Id.ToString(), userId)).Select(x => x.Game).ToList();
			return games;
		}

		public void Save(Game entity)
		{
			try
			{
				if (entity.Id > 0)
					_context.Games.Update(entity);
				else
					_context.Games.Add(entity);

				_context.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
