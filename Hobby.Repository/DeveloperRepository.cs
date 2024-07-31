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
	public class DeveloperRepository : IBaseRepository<Developer>, IDeveloperRepository
	{
		private HobbyContext _context;

		public DeveloperRepository(HobbyContext hobbyContext)
		{
			_context = hobbyContext;
		}

		public void Add(Developer entity)
		{
			try
			{
				_context.Developers.Add(entity);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void Delete(Developer entity)
		{
			try
			{
				_context.Developers.Remove(entity);
				_context.SaveChanges();
			}
			catch (Exception)
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

		public void Update(Developer entity)
		{
			throw new NotImplementedException();
		}
	}
}
