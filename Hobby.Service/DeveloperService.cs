using Games.Model;
using Games.Service.Interfaces;
using Hobby.Repository.Interfaces;
using Hobby.Service.Interfaces;

namespace Hobby.Service
{
	public class DeveloperService : IDeveloperService
	{
		private readonly IDeveloperRepository _developerRepository;

		public DeveloperService(IDeveloperRepository developerRepository)
		{
			this._developerRepository = developerRepository;
		}

		public void Delete(int id)
		{
			try
			{
				Developer? developer = _developerRepository.Get(id);

				if (developer == null)
					throw new Exception("There's no developer to remove.");

				_developerRepository.Delete(developer);
			}
			catch (Exception e)
			{

				throw;
			}
		}

		public Developer? GetById(int id)
		{
			return _developerRepository.Get(id);
		}

		public void Remove(int id)
		{
			Developer? developer = GetById(id);
			_developerRepository.Delete(developer);
		}

		public IList<Developer> ListAll()
		{
			return _developerRepository.ListAll();
		}

		public void Save(Developer obj)
		{
			_developerRepository.Save(obj);
		}
	}
}
