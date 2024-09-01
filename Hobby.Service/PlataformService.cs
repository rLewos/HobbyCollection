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

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Plataform? GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IList<Plataform>? ListAll()
		{
			return _plataformRepository.ListAll();
		}

		public void Save(Plataform obj)
		{
			try
			{
				_plataformRepository.Save(obj);
			}
			catch (Exception e)
			{

				throw;
			}
		}

		public void Validate(Plataform t)
		{
			throw new NotImplementedException();
		}
	}
}
