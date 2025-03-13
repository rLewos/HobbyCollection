using Games.Model;

namespace HobbyCollection.Website.ViewModels
{
	public class PlatformViewModel
	{
        public Platform?  Plataform { get; set; }
        public IList<Platform>? PlataformList{ get; set; }

        public PlatformViewModel()
        {
            
        }
    }
}
