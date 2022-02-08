using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sectors.Shared.Dtos
{
    public class UserSectorDto
    {
        [Key]
        public int UserId { get; set; }
        [Key]
        public int SectorId { get; set; }
    }
}
