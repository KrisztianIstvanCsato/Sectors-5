using Sectors.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sectors.Shared
{
    public class Sector
    {
        [Key]
        public int SectorId { get; set; }
        public string Name { get; set; }
        public int Parent { get; set; }
        public int Level { get; set; }

        //Navigation prop
        public virtual List<UserSector> Users { get; set; }
    }
}
