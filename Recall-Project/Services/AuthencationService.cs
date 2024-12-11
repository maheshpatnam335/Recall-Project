using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Recall_Project.Services
{
    public class AuthencationService
    {
        public IConfiguration _configuration;
        public AuthencationService(IConfiguration configuration)
        {
        _configuration= configuration;
        }

        public string GenerateToken()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:key"]));
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = new[] { new Claim(JwtRegisteredClaimNames.Sub, "Mahesh") };
            var token = new JwtSecurityToken(audience: _configuration["Jwt:audience"], issuer: _configuration["Jwt:issuer"], claims: claims,
                signingCredentials: signingCredentials, expires: DateTime.Now.AddMinutes(5));
            var r = new JwtSecurityTokenHandler().WriteToken(token);
            return r;
            //{
            //    Audiences = _configuration["Jwt:audience"],
            //    Issuer = _configuration["Jwt:issuer"],
            //    Claims = claims,
            //    SigningCredentials = signingCredentials,
            //    expires=DateTime.UtcNow.AddDays(1)
            //};
        }
    }
}
