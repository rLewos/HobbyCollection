using HobbyCollection.Website.Models.DTO;

namespace HobbyCollection.Website.ViewModels
{
	public class PlatformViewModel
	{
        public PlatformDto?  Plataform { get; set; }
        public IList<PlatformDto>? PlataformList{ get; set; }

        public PlatformViewModel()
        {
            
        }
    }
}
