using Games.Model;
using Games.Service.Interfaces;
using Hobby.Repository.Interfaces;
using Hobby.Service.Interfaces;

namespace Hobby.Service
{
	public class PlatformService : IPlatformService
	{
		private readonly IPlatformRepository _iPlatformRepository;

		public PlatformService(IPlatformRepository iPlatformRepository)
		{
			this._iPlatformRepository = iPlatformRepository;
		}

		public Platform? GetById(int id)
		{
			return _iPlatformRepository.GetById(id);
		}

		public void Remove(int id)
		{
			Platform? platform = GetById(id);
			_iPlatformRepository.Delete(platform);
		}

		public IList<Platform>? ListAll()
		{
			return _iPlatformRepository.ListAll();
		}

		public void Save(Platform obj)
		{
			try
			{
				_iPlatformRepository.Save(obj);
			}
			catch (Exception e)
			{

				throw;
			}
		}
	}
}
