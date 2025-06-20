using System.Text.Json.Serialization;

namespace HobbyCollection.Website.Models.DTO
{
	public class BaseDto
	{
		[JsonRequired]
		public int Id { get; set; }
	}
}
