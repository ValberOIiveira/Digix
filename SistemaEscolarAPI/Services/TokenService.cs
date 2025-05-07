using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaEscolarAPI.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace SistemaEscolarAPI.Services
{
    public class TokenService
    {
        public static string GenerateToken(Usuario usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes("minha-chave-ultra-segura-com-32-caracteres");

            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, usuario.Username)
                }),
                Expires = DateTime.UtcNow.AddHours(1), // define o tempo de expiração do token

                SigningCredentials = new SigningCredentials (new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}