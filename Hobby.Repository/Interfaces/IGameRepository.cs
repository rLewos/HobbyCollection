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
		Game? GetByName(string gameName);
		IList<Game> ListAll();
		IList<Game> ListByUserId(string userId);
	}
}
