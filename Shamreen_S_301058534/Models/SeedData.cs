using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shamreen_S_301058534.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Clubs.Any())
            {
                context.Clubs.AddRange(
 new Club
 {
     
     Name = "Brampton Stars",
     Club_City = "Brampton",
     Club_Description = "It is a soccer club ",
     Club_Owner = "Kim",
     Club_Manger = "Phill",
     Club_Value = 245m


 },
                 new Club
                 {
                     
                     Name = "Scarborough Shoots",
                     Club_City = "Scarborough",
                     Club_Description = "It is a soccer club ",
                     Club_Owner = "Khan",
                     Club_Manger = "Phillips",
                     Club_Value = 270m
                 
                 }  
                 );
                context.SaveChanges();
        }
    }
}}