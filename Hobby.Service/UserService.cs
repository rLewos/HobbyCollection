using Games.Model;
using Games.Service.Interfaces;
using Hobby.Repository.Interfaces;
using Hobby.Service.Interfaces;

namespace Hobby.Service
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public User? GetById(int id)
		{
			return _userRepository.Get(id);
		}

		public void Remove(int id)
		{
			User? user = GetById(id);
			_userRepository.Delete(user);
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
	}
}
