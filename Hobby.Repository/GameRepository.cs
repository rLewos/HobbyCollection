using Games.Infraestructure;
using Games.Model;
using Games.Repository.Interfaces;

namespace Games.Repository
{
	public class GameRepository : IBaseRepository<Game>, IGameRepository
	{
		private HobbyContext _context;

		public GameRepository(HobbyContext hobbyContext)
		{
			_context = hobbyContext;	
		}

		public void Add(Game entity)
		{
			try
			{
				_context.Games.Add(entity);
				_context.SaveChanges();
			}
			catch (Exception e)
			{
				
				throw;
			}
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
			IList<Game> list = new List<Game>();
			list = _context.Games.ToList();

			return list;
		}

		public void Update(Game entity)
		{
			throw new NotImplementedException();
		}
	}
}
