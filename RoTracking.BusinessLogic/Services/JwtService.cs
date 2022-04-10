using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.BusinessLogic.Services
{
    public class JwtService
    {
        private string secureKey = "My first jwt token implementation";

        public string GenerateToken(Guid id)
        {
            var simetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secureKey));
            var credentials = new SigningCredentials(simetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var header = new JwtHeader(credentials);

            var payload = new JwtPayload(id.ToString(), null, null, null, DateTime.Today.AddDays(1));
            var securityToken = new JwtSecurityToken(header, payload);

            return securityToken.ToString();

        }

        public JwtSecurityToken Verify(string jwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secureKey);
            tokenHandler.ValidateToken(jwt, new TokenValidationParameters { IssuerSigningKey = new SymmetricSecurityKey(key), ValidateIssuerSigningKey = true, ValidateIssuer = false, ValidateAudience = false }, out SecurityToken validatenToken);
            return (JwtSecurityToken)validatenToken;
        }
    }
}
