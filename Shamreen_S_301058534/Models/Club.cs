using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shamreen_S_301058534.Models
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Club_Description { get; set; }
        public string Club_Owner { get; set; }
        public string Club_Manger { get; set; }

        public decimal Club_Value { get; set; }
        public string Club_City { get; set; }
        public virtual ICollection<Player> Players { get; set; }

    }
}

