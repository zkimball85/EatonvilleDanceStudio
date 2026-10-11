using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EatonvilleDanceStudio.Data
{
    // Inheriting from IdentityDbContext gives us all the built-in auth tables automatically
    public class EatonvilleDanceStudioDb : IdentityDbContext<ApplicationUser>
    {
        public EatonvilleDanceStudioDb(DbContextOptions<EatonvilleDanceStudioDb> options) : base(options)
        {
        }

    }
}
