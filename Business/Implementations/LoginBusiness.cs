using JWT.Authentication.Api.Interfaces;
using JWT.Authentication.Api.ValueObjects;

namespace JWT.Authentication.Api.Business.Implementations
{
    public class LoginBusiness : ILoginBusiness
    {
        public TokenVO ValidateCredentials(UserVO user)
        {
            throw new NotImplementedException();
        }

        public TokenVO ValidateCredentials(TokenVO token)
        {
            throw new NotImplementedException();
        }

        public bool RevokeToken(string username)
        {
            throw new NotImplementedException();
        }
    }
}