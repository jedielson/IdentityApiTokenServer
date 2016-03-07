using System.Data.Entity;
using System.Data.Entity.Migrations;
using IdentityStudy.Api.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace IdentityStudy.Api.Models
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        static AuthContext()
        {
            var endureDllsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public AuthContext()
            : base("AuthContext")
        {

        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}