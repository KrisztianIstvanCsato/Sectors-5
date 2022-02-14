using Sectors.Shared.Models;
using System.ComponentModel.DataAnnotations;

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
