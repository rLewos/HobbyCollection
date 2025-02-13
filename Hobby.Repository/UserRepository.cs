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

		public User GetByName(string name)
		{
			return _context.Users.SingleOrDefault(u => u.Name == name);
		}

		public IList<User> ListAll()
		{
			return _context.Users.ToList();
		}

		public bool Login(string nickname, string password)
		{
			User? userLogin = this.GetByNickname(nickname);

			bool isNicknameRight = userLogin != null && (string.Equals(userLogin.Nickname, nickname));
			bool isPasswordRight = userLogin != null && (string.Equals(userLogin.Password, password));
			
			// TODO:  password
			return isNicknameRight && isPasswordRight;
		}

		public User? GetByNickname(string nickname)
		{
			return _context.Users.SingleOrDefault(u => u.Nickname == nickname);
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
