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
	public class PublisherService : IBaseService<Publisher>, IPublisherService
	{
		private readonly IPublisherRepository _publisherRepository;

        public PublisherService(IPublisherRepository publisherRepository)
        {
            this._publisherRepository = publisherRepository;
        }


        public void Delete(int? codObj)
		{
			throw new NotImplementedException();
		}

		public Publisher? Get(int? codObj)
		{
			throw new NotImplementedException();
		}

		public void Save(Publisher obj)
		{
			throw new NotImplementedException();
		}

		public void Update(Publisher obj)
		{
			throw new NotImplementedException();
		}

		public void Validate(Publisher t)
		{
			throw new NotImplementedException();
		}
	}
}
