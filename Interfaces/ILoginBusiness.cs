using JWT.Authentication.Api.ValueObjects;

namespace JWT.Authentication.Api.Interfaces
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);
        TokenVO ValidateCredentials(TokenVO token);
        bool RevokeToken(string username);
    }
}