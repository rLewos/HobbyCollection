﻿using Games.Model;
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
			User? usuarioLogin = _userRepository.Login(user.userName, user.password);
			if (usuarioLogin != null)
			{
				SymmetricSecurityKey secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"] ?? string.Empty));
				string issuer = _configuration["JWT:Issuer"];
				string audience = _configuration["JWT:Audience"];

				SigningCredentials signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
				JwtSecurityToken tokenOptions = new JwtSecurityToken(
					issuer,
					audience,
					claims: new[] { 
						new Claim(ClaimTypes.Name, usuarioLogin.Name),
						new Claim(ClaimTypes.Role, usuarioLogin.Role.Name)
					},
					expires: DateTime.Now.AddHours(1),
					signingCredentials: signingCredentials
				);

				string token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
				return token;	
			}
			
			return null;
		}
	}
}
