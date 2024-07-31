using Games.Infraestructure;
using Games.Model;
using Games.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.Repository
{
	public class PlataformRepository : IBaseRepository<Plataform>, IPlatformRepository
	{
		private HobbyContext _context;

		public PlataformRepository(HobbyContext hobbyContext)
		{
			_context = hobbyContext;
		}

		public void Add(Plataform entity)
		{
			try
			{
				_context.Plataforms.Add(entity);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
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

		public void Update(Plataform entity)
		{
			throw new NotImplementedException();
		}
	}
}
