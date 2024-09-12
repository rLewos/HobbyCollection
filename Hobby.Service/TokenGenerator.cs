using Games.Model;
using Hobby.Model.DTO;
using Hobby.Repository.Interfaces;
using Hobby.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Hobby.Service
{
	public class TokenGenerator : ITokenGenerator
	{
		private readonly IConfiguration _configuration;
		private readonly IUserRepository _userRepository;

		public TokenGenerator(IConfiguration configuration, IUserRepository userRepository)
		{
			_configuration = configuration;
			_userRepository = userRepository;
		}

		public string GenerateToken(LoginDTO user)
		{
			var userLogin = _userRepository.GetByName(user.userName);

			// TODO:  password
			if (userLogin == null || !(userLogin.Nickname == user.userName))
				return string.Empty;

			var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"] ?? string.Empty));
			string issuer = _configuration["JWT:Issuer"];
			string audience = _configuration["JWT:Audience"];

			var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
			var tokenOptions = new JwtSecurityToken(
				issuer,
				audience,
				claims: new[] { new Claim(ClaimTypes.Name, "Galo Cego") },
				expires: DateTime.Now.AddHours(1),
				signingCredentials: signingCredentials
				);

			string token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

			return token;
		}
	}
}
