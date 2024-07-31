using Games.Model;
using Games.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.Repository.Interfaces
{
	public interface IPublisherRepository : IBaseRepository<Publisher>
	{
		Publisher? GetByName(string publisherName);
		IList<Publisher> ListAll();
	}
}
