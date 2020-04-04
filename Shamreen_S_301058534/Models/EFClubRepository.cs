using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shamreen_S_301058534.Models
{
    public class EFClubRepository : IClubRepository
    {
        private ApplicationDbContext context;

        public EFClubRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

     
        public Club Add(Club club)
        {
            context.Clubs.Add(club);
            context.SaveChanges();
            return club;
        }

        public Club Delete(int Id)
        {
            Club club = context.Clubs.Find(Id);
            if(club!=null)
            {
                context.Clubs.Remove(club);
                context.SaveChanges();
            }
            return club;
        }

        public IEnumerable<Club> Getallclubs()
        {
            return context.Clubs;
        }

        public Club GetClub(int Id)
        {
          return  context.Clubs.Find(Id);

        }

        public Club Update(Club updateclub)
        {


            Club club = context.Clubs.FirstOrDefault(c => c.Id == updateclub.Id);
            if (club != null)
            {
                club.Name = updateclub.Name;
                club.Club_Owner = updateclub.Club_Owner;
                club.Club_Manger = updateclub.Club_Manger;
                club.Club_Value = updateclub.Club_Value;
                club.Club_Description = updateclub.Club_Description;
                club.Club_City = updateclub.Club_City;

            }
            context.Entry(club).State = EntityState.Modified;
            context.SaveChanges();
          
                return updateclub;
            
     
            
        }

       
    }
}
