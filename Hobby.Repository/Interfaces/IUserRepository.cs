using Games.Model;
using Games.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.Repository.Interfaces
{
	public interface IUserRepository : IBaseRepository<User>
	{
		User? GetByName(string name);
		IList<User> ListAll();
		User? Login(string nickname, string password);
		User? GetByNickname(string nickname);
	}
}
