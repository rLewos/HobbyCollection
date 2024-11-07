using Games.Infraestructure;
using Games.Model;
using Games.Repository.Interfaces;
using Hobby.Repository.Interfaces;

namespace Hobby.Repository
{
	public class PlataformRepository : IBaseRepository<Plataform>, IPlataformRepository
	{
		private HobbyContext _context;

		public PlataformRepository(HobbyContext hobbyContext)
		{
			_context = hobbyContext;
		}

		public void Delete(Plataform entity)
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

		public Plataform Get(int id)
		{
			return _context.Plataforms.SingleOrDefault(p => p.Id == id);
		}

		public Plataform GetByName(string platformName)
		{
			return _context.Plataforms.SingleOrDefault(p => p.Name == platformName);
		}

		public IList<Plataform> ListAll()
		{
			return _context.Plataforms.ToList();
		}

		public void Save(Plataform entity)
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
