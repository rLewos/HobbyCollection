using Games.Model;
using Games.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.Repository.Interfaces
{
	public interface IDeveloperRepository : IBaseRepository<Developer>
	{
		Developer? GetByName(string developerName);
		IList<Developer> ListAll();
	}
}
