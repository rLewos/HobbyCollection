using Games.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using HobbyCollection.Website.Models.DTO;

namespace Hobby.Model.DTO
{
	public class GameDto : HobbyCollection.Website.Models.DTO.BaseDto
	{
		[JsonInclude]
		public string? Name { get; set; }

		[JsonInclude]
        public DateTime? ReleaseDate { get; set; }

		[JsonInclude]
		public IList<HobbyCollection.Website.Models.DTO.DeveloperDto>? DeveloperList { get; set; }

		[JsonInclude]
		public IList<PublisherDto>? PublisherList { get; set; }
		
		[JsonInclude]
		public IList<PlatformDto>? PlataformList { get; set; }
	}
}
