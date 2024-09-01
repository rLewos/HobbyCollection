using Games.Model;
using Games.Service.Interfaces;
using Hobby.Repository.Interfaces;
using Hobby.Service.Interfaces;

namespace Hobby.Service
{
	public class DeveloperService : IBaseService<Developer>, IDeveloperService
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
			throw new NotImplementedException();
		}

		public IList<Developer> ListAll()
		{
			return _developerRepository.ListAll();
		}

		public void Save(Developer obj)
		{
			_developerRepository.Save(obj);
		}

		public void Validate(Developer t)
		{
			throw new NotImplementedException();
		}
	}
}
