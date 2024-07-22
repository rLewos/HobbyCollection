using Games.Model;

namespace HobbyCollection.Website.ViewModels
{
	public class UserViewModel
	{
        public User? User { get; set; }
		public IList<User>? UserList { get; set; }

		public UserViewModel()
        {
            
        }
    }
}
