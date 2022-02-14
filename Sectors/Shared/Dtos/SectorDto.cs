using System.ComponentModel.DataAnnotations;

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
