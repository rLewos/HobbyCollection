using Games.Infraestructure;
using Games.Model;
using Games.Repository.Interfaces;
using Hobby.Repository.Interfaces;

namespace Hobby.Repository
{
	public class PlatformRepository : IBaseRepository<Platform>, IPlatformRepository
	{
		private HobbyContext _context;

		public PlatformRepository(HobbyContext hobbyContext)
		{
			_context = hobbyContext;
		}

		public void Delete(Platform entity)
		{
			try
			{
				_context.Plataforms.Remove(entity);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public Platform Get(int id)
		{
			return _context.Plataforms.SingleOrDefault(p => p.Id == id);
		}

		public Platform GetByName(string platformName)
		{
			return _context.Plataforms.SingleOrDefault(p => p.Name == platformName);
		}

		public IList<Platform> ListAll()
		{
			return _context.Plataforms.ToList();
		}

		public Platform? GetById(int id)
		{
			return _context.Plataforms.SingleOrDefault(x => x.Id == id);
		}

		public void Save(Platform entity)
		{
			try
			{
				if(entity.Id > 0)
					_context.Plataforms.Update(entity);
				else 
					_context.Plataforms.Add(entity);

				_context.SaveChanges();
			}
			catch (Exception e)
			{
				throw;
			}
		}
	}
}
