using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ResumeIQ.Services;

public class JwtService
{
    public string GenerateToken(string email)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Email, email)
        };

        return new JwtSecurityTokenHandler()
            .WriteToken(
                new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.UtcNow.AddDays(1)
                )
            );
    }
}
