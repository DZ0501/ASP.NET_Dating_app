using Foundation.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Foundation.Areas.Identity.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<FoundationContext>();
            context.Database.EnsureCreated();

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var roleName = "Administrator";
            var roleName_2 = "Authorized";

            IdentityResult result;

            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                result = await roleManager.CreateAsync(new IdentityRole(roleName));
                if (result.Succeeded)
                {
                    var userManager = serviceProvider.GetRequiredService<UserManager<FoundationUser>>();
                    var config = serviceProvider.GetRequiredService<IConfiguration>();
                    var admin = await userManager.FindByEmailAsync(config["AdminCredentials:Email"]);
                    
                    if (admin == null)
                    {
                        admin = new FoundationUser()
                        {
                            UserName = config["AdminCredentials:Email"],
                            Email = config["AdminCredentials:Email"],
                            EmailConfirmed = true
                        };

                        result = await userManager.CreateAsync(admin, config["AdminCredentials:Password"]);
                        if (result.Succeeded)
                        {
                            result = await userManager.AddToRoleAsync(admin, roleName);
                            if (!result.Succeeded)
                            {
                                // todo: process errors
                            }
                        }
                    }
                }

                IdentityResult result_2;
                result_2 = await roleManager.CreateAsync(new IdentityRole(roleName_2));
            }
        }
    }
}
