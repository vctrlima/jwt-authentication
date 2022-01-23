using System.Security.Claims;

namespace JWT.Authentication.Api.Services
{
    public interface ITokenService
    {
        string GenerateAccessToken(Claim[] claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}