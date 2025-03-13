using Games.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Service.Interfaces
{
	public interface IGameService : IBaseService<Game>
    {
		Game? GetByName(string gameName);
		IList<Game> ListAll();
		IList<Game> ListByUserId(string userId);
    }
}
