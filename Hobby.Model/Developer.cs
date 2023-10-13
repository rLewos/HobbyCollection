﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Model
{
    public class Developer : BaseModel
    {
        public string? Name { get; set; }
        public IList<Game>? GameList { get; set; }

		public override void Validate()
		{
			throw new NotImplementedException();
		}
	}
}
