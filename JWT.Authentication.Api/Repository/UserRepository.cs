using JWT.Authentication.Api.Interfaces;
using JWT.Authentication.Api.Models.Context;

namespace JWT.Authentication.Api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MSSQLContext _context;

        public UserRepository(MSSQLContext context)
        {
            _context = context;
        }
    }
}