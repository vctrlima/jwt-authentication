using JWT.Authentication.Api.Models;
using JWT.Authentication.Api.Models.Context;
using JWT.Authentication.Api.ValueObjects;

using System.Security.Cryptography;
using System.Text;

namespace JWT.Authentication.Api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MSSQLContext _context;

        public UserRepository(MSSQLContext context)
        {
            _context = context;
        }

        public User ValidateCredentials(UserVO user)
        {
            var pass = ComputeHash(user.Password, new SHA256CryptoServiceProvider());

            return _context.Users.FirstOrDefault(u => (u.Username == user.Username) && (u.Password == pass));
        }

        public User ValidateCredentials(string username)
        {
            return _context.Users.SingleOrDefault(u => u.Username == username);
        }

        public bool RevokeToken(string username)
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == username);

            if (user is null)
                return false;
            
            user.RefreshToken = null;

            _context.SaveChanges();

            return true;
        }

        public User RefreshUserInfo(User user)
        {
            throw new NotImplementedException();
        }

        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
    }
}