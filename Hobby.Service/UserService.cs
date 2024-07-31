using Games.Model;
using Games.Service.Interfaces;
using Hobby.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.Service
{
	public class UserService : IBaseService<User>, IUserService
	{


		public UserService() { }

		public void Delete(int? codObj)
		{
			throw new NotImplementedException();
		}

		public User? Get(int? codObj)
		{
			throw new NotImplementedException();
		}

		public void Save(User obj)
		{
			throw new NotImplementedException();
		}

		public void Update(User obj)
		{
			throw new NotImplementedException();
		}

		public void Validate(User t)
		{
			throw new NotImplementedException();
		}
	}
}
