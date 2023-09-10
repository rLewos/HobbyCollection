using Games.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Repository.Interfaces
{
	public interface IGameRepository : IBaseRepository<Game>
	{
		IList<Game> ListAll();
	}
}
