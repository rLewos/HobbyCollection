using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Model
{
    public class User : BaseModel
    {
        public string? Name { get; set; }
        public string? Nickname { get; set; }
        public IList<Game>? GameList { get; set; }
        public IList<UserGame>? UserGameList { get; set; }
    }
}
