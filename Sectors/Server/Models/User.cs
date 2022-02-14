using Sectors.Shared.Models;
using System.ComponentModel.DataAnnotations;

namespace Sectors.Shared
{
    public class User
    {
        public User()
        {
            Sectors = new List<UserSector>();
        }

        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public virtual List<UserSector> Sectors { get; set; }
    }
}
