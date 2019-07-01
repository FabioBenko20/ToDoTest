using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Helpers.Interfaces;
using TodoList.Models;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace TodoList.Helpers
{
    public class JwtHelper: IJwtHelper
    {
        private readonly IConfigSettings _configSettings;

        public JwtHelper( IConfigSettings configSettings)
        {
            _configSettings = configSettings;
        }


        public async Task<Login> GenerateToken(Login login)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configSettings.AccessToken);
            var tokenDescript = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name,login.Name)
                }),
                Expires = DateTime.UtcNow.AddDays(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescript);
            login.AccessToken = tokenHandler.WriteToken(token);

            return login;
        }


    }
}
