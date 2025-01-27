
namespace Games.Model
{
    public class User : BaseModel
    {
        public string? Name { get; set; }
        public string? Nickname { get; set; }
        public string? Password { get; set; }
        public IList<Game>? GameList { get; set; }
        public IList<UserGame>? UserGameList { get; set; }

        public Roles Role { get; set; }

		public void Validate()
		{
			if (string.IsNullOrEmpty(this.Name))
				throw new Exception("Username is empty");

			if (string.IsNullOrEmpty(this.Nickname))
				throw new Exception("Nickname is empty");


		}
	}
}
