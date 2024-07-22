using Games.Model;

namespace HobbyCollection.Website.ViewModels
{
	public class DeveloperViewModel
	{
        public Developer? Developer { get; set; }
        public IList<Developer>? DeveloperList { get; set; }

        public DeveloperViewModel() { }
    }
}
