using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sectors.Shared.Models
{
    public class UserSector
    {
        [Key]
        public int UserId { get; set; }
        public User? User { get; set; }

        [Key]
        public int SectorId { get; set; }
        public Sector? Sector { get; set; }
    }
}
