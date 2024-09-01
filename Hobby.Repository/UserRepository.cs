using Games.Infraestructure;
using Games.Model;
using Games.Repository.Interfaces;
using Hobby.Repository.Interfaces;

namespace Hobby.Repository
{
	public class UserRepository : IBaseRepository<User>, IUserRepository
	{
		private HobbyContext _context;

		public UserRepository(HobbyContext hobbyContext)
		{
			_context = hobbyContext;
		}

		public void Delete(User entity)
		{
			try
			{
				_context.Users.Remove(entity);
				_context.SaveChanges();
			}
			catch (Exception e)
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

		public void Save(User entity)
		{
			try
			{
				if (entity.Id > 0)
					_context.Users.Update(entity);
				else
					_context.Users.Add(entity);
				
				_context.SaveChanges();
			}
			catch (Exception e)
			{

				throw;
			}
		}
	}
}
