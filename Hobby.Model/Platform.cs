using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Model
{
	public class Platform : BaseModel
    {
        public string? Name { get; set; }
        public string? Abbreviation { get; set; }
        public IList<Game>? GameList { get; set; }
	}
}
