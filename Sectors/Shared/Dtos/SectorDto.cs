using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sectors.Shared.Dtos
{
    public class SectorDto
    {
        [Key]
        public int SectorId { get; set; }
        public string Name { get; set; }
        public int Parent { get; set; }
        public int Level { get; set; }
    }
}
