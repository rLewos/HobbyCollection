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


		public void Delete(int? codObj)
		{
			throw new NotImplementedException();
		}

		public Developer? Get(int? codObj)
		{
			throw new NotImplementedException();
		}

		public void Save(Developer obj)
		{
			throw new NotImplementedException();
		}

		public void Update(Developer obj)
		{
			throw new NotImplementedException();
		}

		public void Validate(Developer t)
		{
			throw new NotImplementedException();
		}
	}
}
