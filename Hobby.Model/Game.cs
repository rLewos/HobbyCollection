using FluentValidation.Results;
using Games.Model.Validations;

namespace Games.Model
{
    public class Game : BaseModel
    {
        public string? Name { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public IList<Developer>? DeveloperList { get; set; }
        public IList<Publisher>? PublisherList { get; set; }
        public IList<Platform>? PlataformList { get; set; }

        
        public IList<User>? UserList { get; set; }
        
        /// <summary>
        /// Intermediate UserGame table
        /// </summary>
        public IList<UserGame>? UserGameList { get; set; }

		public override ValidationResult Validate()
		{
            return new GameValidator().Validate(this);
		}
	}
}
