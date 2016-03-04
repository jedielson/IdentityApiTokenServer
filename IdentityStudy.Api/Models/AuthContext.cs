using Microsoft.AspNet.Identity.EntityFramework;

namespace IdentityStudy.Api.Models
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}