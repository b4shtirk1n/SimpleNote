using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace SimpleNoteAPI.Services
{
    public class AuthService
    {
        public const string ISSUER = "SimpleNote";
        public const string AUDIENCE = "Client";
        private const string KEY = "SimpleNote";

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
            => new(SHA256.HashData(Encoding.UTF8.GetBytes(KEY)));

        public string GetToken()
        {
            var claims = new List<Claim>();

            var token = new JwtSecurityToken(
                issuer: ISSUER,
                audience: AUDIENCE,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(5),
                signingCredentials: new SigningCredentials(GetSymmetricSecurityKey(),
                    SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
