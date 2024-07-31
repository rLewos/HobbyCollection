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
	public class UserRepository : IBaseRepository<User>, IUserRepository
	{
		private HobbyContext _context;

		public UserRepository(HobbyContext hobbyContext)
		{
			_context = hobbyContext;
		}

		public void Add(User entity)
		{
			try
			{
				_context.Users.Add(entity);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void Delete(User entity)
		{
			try
			{
				_context.Users.Remove(entity);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public User Get(int id)
		{
			return _context.Users.SingleOrDefault(u => u.Id == id);
		}

		public User GetByName(string userName)
		{
			return _context.Users.SingleOrDefault(u => u.Name == userName);
		}

		public IList<User> ListAll()
		{
			return _context.Users.ToList();
		}

		public void Update(User entity)
		{
			throw new NotImplementedException();
		}
	}
}
