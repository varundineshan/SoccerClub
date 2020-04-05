using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shamreen_S_301058534.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "Proj";
        private const string adminPassword = "Proj123$";
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            UserManager<IdentityUser> userManager = app.ApplicationServices.GetRequiredService<UserManager<IdentityUser>>();
            AppIdentityDbContext context = app.ApplicationServices
                .GetRequiredService<AppIdentityDbContext>();
            context.Database.Migrate();
            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            
            if (user == null) 
            { 
                user = new IdentityUser("Proj"); 
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}
