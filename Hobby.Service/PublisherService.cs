using Games.Model;
using Games.Service.Interfaces;
using Hobby.Repository.Interfaces;
using Hobby.Service.Interfaces;

namespace Hobby.Service
{
	public class PublisherService : IPublisherService
	{
		private readonly IPublisherRepository _publisherRepository;

        public PublisherService(IPublisherRepository publisherRepository)
        {
            this._publisherRepository = publisherRepository;
        }

		public Publisher? GetById(int id)
		{
			return _publisherRepository.Get(id);
		}

		public void Remove(int id)
		{
			Publisher? publisher = GetById(id);
			_publisherRepository.Delete(publisher);
		}

		public IList<Publisher>? ListAll()
		{
			return _publisherRepository.ListAll();
		}

		public void Save(Publisher obj)
		{
			_publisherRepository.Save(obj);	
		}
	}
}
