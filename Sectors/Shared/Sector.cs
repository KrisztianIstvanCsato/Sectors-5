using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sectors.Shared
{
    public class Sector
    {
        public int Id { get; set; }
        public int SectorId { get; set; }
        public string Name { get; set; }

        //Navigation prop
        public ICollection<User_Sector> Users { get; set; }
    }
}
