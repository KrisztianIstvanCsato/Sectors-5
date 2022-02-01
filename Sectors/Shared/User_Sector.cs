using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sectors.Shared
{
    public class User_Sector
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int SectorId { get; set; }
        public Sector Sector { get; set; }
    }
}
