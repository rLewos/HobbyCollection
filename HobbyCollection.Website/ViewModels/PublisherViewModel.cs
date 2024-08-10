using Games.Model;

namespace HobbyCollection.Website.ViewModels
{
	public class PublisherViewModel
	{
        public Publisher? Publisher { get; set; }
        public IList<Publisher>? PublisherList { get; set; }

        public PublisherViewModel() { }
    }
}
