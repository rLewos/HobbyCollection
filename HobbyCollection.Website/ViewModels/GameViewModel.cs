using Games.Model;

namespace HobbyCollection.Website.ViewModels
{
	public class GameViewModel
	{
        public Game? Game { get; set; }
        public IList<Game>? GameList { get; set; }

        public GameViewModel()
        {
            
        }

    }
}
