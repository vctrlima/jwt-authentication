using JWT.Authentication.Api.Models;
using JWT.Authentication.Api.ValueObjects;

namespace JWT.Authentication.Api.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
        User ValidateCredentials(string userName);

        bool RevokeToken(string userName);
        User RefreshUserInfo(User user);
    }
}