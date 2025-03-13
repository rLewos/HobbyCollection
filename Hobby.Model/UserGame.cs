using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Model
{
	public class UserGame : BaseModel
    {
	    public int? UserId { get; set; }
        public User? User { get; set; }
        public int? GameId { get; set; }
        public Game? Game { get; set; }
        public bool HasBeaten { get; set; }
	}
}
