using Games.Infraestructure;
using Games.Model;
using Games.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Repository
{
	public class GameRepository : IGameRepository
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

		public void Delete(Game entity)
		{
			throw new NotImplementedException();
		}

		public Game Get(int id)
		{
			throw new NotImplementedException();
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
