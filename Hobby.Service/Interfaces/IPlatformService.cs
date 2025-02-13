using Games.Model;
using Games.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.Service.Interfaces
{
	public interface IPlatformService : IBaseService<Platform>
	{
		IList<Platform>? ListAll();
	}
}
