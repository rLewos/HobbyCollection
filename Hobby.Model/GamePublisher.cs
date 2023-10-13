using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Model
{
    public class GamePublisher : BaseModel
    {
        public Game? Game { get; set; }
        public Publisher? Publisher { get; set; }
		public override void Validate()
		{
			throw new NotImplementedException();
		}
    }
}
