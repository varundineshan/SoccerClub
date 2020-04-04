using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shamreen_S_301058534.Models
{
    public interface IClubRepository
    {
        Club GetClub(int Id);
        IEnumerable<Club> Getallclubs();
        Club Add(Club club);
        Club Update(Club club);
        Club Delete(int Id);
    }
}
