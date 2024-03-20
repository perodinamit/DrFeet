using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Infrastructure.Context
{
    public static class DefaultUserSeed
    {
        public static async Task SeedDefaultUserAsync(UserManager<IdentityUser> userManager)
        {
            string adminEmail = "drfeet@gmail.com";
            string adminPsw = "Cipele882!";
            if (await userManager.FindByEmailAsync(adminEmail) == null)
            {
                var user = new IdentityUser
                {
                    Email = adminEmail,
                    UserName = adminEmail,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(user, adminPsw);

                await userManager.AddToRoleAsync(user, Roles.Admin.ToString());
            }
        }
    }
}
