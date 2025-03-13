
using FluentValidation.Results;
using Games.Model.Validations;

namespace Games.Model
{
    public class User : BaseModel
    {
        public string? Name { get; set; }
        public string? Nickname { get; set; }
        public string? Password { get; set; }
        public IList<UserGame>? UserGameList { get; set; }
        
        public int? RoleId { get; set; }
        public Roles? Role { get; set; }
        
		
        
		public override ValidationResult Validate()
		{
			return new UserValidator().Validate(this);
		}
	}
}
