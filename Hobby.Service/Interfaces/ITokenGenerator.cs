using Hobby.Model.DTO;

namespace Hobby.Service.Interfaces
{
	public interface ITokenGenerator
	{
		string GenerateToken(LoginDTO user);
	}
}
