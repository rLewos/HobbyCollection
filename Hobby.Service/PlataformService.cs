using Games.Model;
using Games.Service.Interfaces;
using Hobby.Repository.Interfaces;
using Hobby.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hobby.Service
{
	public class PlataformService : IBaseService<Plataform>, IPlataformService
	{
		private readonly IPlataformRepository _plataformRepository;

		public PlataformService(IPlataformRepository plataformRepository)
		{
			this._plataformRepository = plataformRepository;
		}


		public void Delete(int? codObj)
		{
			throw new NotImplementedException();
		}

		public Plataform? Get(int? codObj)
		{
			throw new NotImplementedException();
		}

		public void Save(Plataform obj)
		{
			throw new NotImplementedException();
		}

		public void Update(Plataform obj)
		{
			throw new NotImplementedException();
		}

		public void Validate(Plataform t)
		{
			throw new NotImplementedException();
		}
	}
}
