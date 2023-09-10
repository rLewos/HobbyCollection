using Games.Model;

namespace Games.ViewModel
{
    public class GameViewModel
    {
        public IList<Game>? GameList{ get; set; }
        public Game? Game { get; set; }
    }
}
