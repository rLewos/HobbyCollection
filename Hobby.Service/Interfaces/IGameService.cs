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
        public IList<Game> List();
    }
}
