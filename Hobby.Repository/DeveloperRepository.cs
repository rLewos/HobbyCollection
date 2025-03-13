using Games.Infraestructure;
using Games.Model;
using Games.Repository.Interfaces;
using Hobby.Repository.Interfaces;

namespace Hobby.Repository
{
	public class DeveloperRepository : IBaseRepository<Developer>, IDeveloperRepository
	{
		private HobbyContext _context;

		public DeveloperRepository(HobbyContext hobbyContext)
		{
			_context = hobbyContext;
		}

		public void Delete(Developer entity)
		{
			try
			{
				_context.Developers.Remove(entity);
				_context.SaveChanges();
			}
			catch (Exception e)
			{
				throw;
			}
		}

		public Developer Get(int id)
		{
			return _context.Developers.SingleOrDefault(d => d.Id == id);
		}

		public Developer GetByName(string developerName)
		{
			return _context.Developers.SingleOrDefault(d => d.Name == developerName);
		}

		public IList<Developer> ListAll()
		{
			return _context.Developers.ToList();
		}

		public void Save(Developer entity)
		{
			try
			{
				if (entity.Id > 0)
					_context.Developers.Update(entity);
				else
					_context.Developers.Add(entity);

				_context.SaveChanges();
			}
			catch (Exception e)
			{
				throw;
			}
		}

	}
}
