using Microsoft.EntityFrameworkCore;

namespace JWT.Authentication.Api.Models.Context
{
    public class MSSQLContext : DbContext
    {
        public MSSQLContext() { }

        public MSSQLContext(DbContextOptions<MSSQLContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}