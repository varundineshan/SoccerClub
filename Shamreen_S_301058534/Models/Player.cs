using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shamreen_S_301058534.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Club_Name { get; set; }
        public string Player_Position { get; set; }
        public string Player_Age { get; set; }

        [ForeignKey("ClubId")]
        public int ClubId { get; set; }
        public virtual Club club { get; set; }
 


    }
}
