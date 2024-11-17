using Games.Model;
using Games.Service.Interfaces;
using Hobby.Repository.Interfaces;
using Hobby.Service.Interfaces;

namespace Hobby.Service
{
	public class PublisherService : IBaseService<Publisher>, IPublisherService
	{
		private readonly IPublisherRepository _publisherRepository;

        public PublisherService(IPublisherRepository publisherRepository)
        {
            this._publisherRepository = publisherRepository;
        }

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Publisher? GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IList<Publisher>? ListAll()
		{
			return _publisherRepository.ListAll();
		}

		public void Save(Publisher obj)
		{
			_publisherRepository.Save(obj);	
		}

		public void Validate(Publisher t)
		{
			throw new NotImplementedException();
		}
	}
}
