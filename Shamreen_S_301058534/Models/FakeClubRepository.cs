using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shamreen_S_301058534.Models
{
    public class FakeClubRepository:IClubRepository
    {

        private List<Club> club_List;

        public FakeClubRepository()
        {
            club_List = new List<Club>()
            {
                new Club() {Id=1,Name="Brampton Stars",Club_Owner="Mait",Club_Description=" It is a premier football club",Club_Manger="Alex",Club_City="Brampton",Club_Value=28989},
                new Club() {Id=2,Name="Scarborough Soccers",Club_Owner="John",Club_Description=" It is a premier football club",Club_Manger="Normstin",Club_City="Scarborough",Club_Value=256}
            };
        }

        public Club Add(Club club)
        {
            club.Id = club_List.Max(c => c.Id) + 1;
            club_List.Add(club);
            return club;
        }

        public Club Delete(int Id)
        {
            Club club=club_List.FirstOrDefault(c=>c.Id==Id);
            if(club!=null)
            {
                club_List.Remove(club);
            }
            return club;
        }

        public IEnumerable<Club> Getallclubs()
        {
            return club_List;
        }

        public Club GetClub(int Id)
        {
            return club_List.FirstOrDefault(c => c.Id == Id);
        }

        public Club Update(Club updateclub)
        {
            Club club = club_List.FirstOrDefault(c => c.Id == updateclub.Id);
            if (club != null)
            {
                club.Name = updateclub.Name;
                club.Club_Owner = updateclub.Club_Owner;
                club.Club_Manger = updateclub.Club_Manger;
                club.Club_Value = updateclub.Club_Value;
                club.Club_Description = updateclub.Club_Description;
                club.Club_City = updateclub.Club_City;

            }
            return club;
        }

        public Club Update(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
