using Microsoft.AspNetCore.Identity;

namespace EatonvilleDanceStudio.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            // specific roles required for the application
            string[] roleNames = { "Parent", "Dancer", "Instructor", "Director" };

            foreach (var roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
    }
}
