using Games.Model;
using Games.Service.Interfaces;
using Hobby.Repository.Interfaces;
using Hobby.Service.Interfaces;

namespace Hobby.Service
{
	public class UserService : IBaseService<User>, IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public User? GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IList<User> ListAll()
		{
			return _userRepository.ListAll();
		}

		public void Save(User obj)
		{
			try
			{
				obj.Validate();


				_userRepository.Save(obj);
			}
			catch (Exception e)
			{

				throw;
			}
		}

		public void Validate(User t)
		{
			throw new NotImplementedException();
		}
	}
}
