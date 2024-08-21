using Games.Model;
using Games.Service.Interfaces;

namespace Hobby.Service.Interfaces
{
	public interface IDeveloperService : IBaseService<Developer>
	{
		IList<Developer> ListAll();
	}
}
