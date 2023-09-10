using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Model
{
    public class GameDeveloper : BaseModel
    {
        public Game? Game { get; set; }
        public Developer? Developer { get; set; }
    }
}
