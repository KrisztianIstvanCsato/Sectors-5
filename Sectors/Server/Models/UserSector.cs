using System.ComponentModel.DataAnnotations;

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
