using Games.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hobby.Model.DTO
{
	public class GameDTO : BaseDTO
	{
		[JsonInclude]
		public string? Name { get; set; }

		[JsonInclude]
        public DateTime? ReleaseDate { get; set; }

		[JsonInclude]
		public IList<DeveloperDTO>? DeveloperList { get; set; }

		[JsonInclude]
		public IList<PublisherDTO>? PublisherList { get; set; }
		
		[JsonInclude]
		public IList<PlataformDTO>? PlataformList { get; set; }
	}
}
