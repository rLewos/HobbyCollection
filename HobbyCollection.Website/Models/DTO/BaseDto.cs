using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hobby.Model.DTO
{
	public class BaseDTO
	{
		[JsonRequired]
		public int Id { get; set; }
		public BaseDTO() { }

	}
}
