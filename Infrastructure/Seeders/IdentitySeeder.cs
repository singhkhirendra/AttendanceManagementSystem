using Domain.Constants;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Infrastructure.Seeders
{
    public static class IdentitySeeder
    {
        public static async Task SeedRolesAsync(RoleManager<ApplicationRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync(RoleConstants.Admin))
            {
                await roleManager.CreateAsync(new ApplicationRole { Name = RoleConstants.Admin });
            }

            if (!await roleManager.RoleExistsAsync(RoleConstants.User))
            {
                await roleManager.CreateAsync(new ApplicationRole { Name = RoleConstants.User });
            }
        }
    }
}
