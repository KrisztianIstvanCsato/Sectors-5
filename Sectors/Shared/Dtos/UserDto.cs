using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sectors.Shared.Dtos
{
    public class UserDto
    {
        public UserDto()
        {
            Sectors = new List<UserSectorDto>();
        }

        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Enter a name!")]
        [MinLength(3, ErrorMessage = "The name is too short!")]
        [StringLength(50, ErrorMessage = "The name is too long!")]
        public string Name { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true",
        ErrorMessage = "Your agreement is required!")]
        public bool Agreed { get; set; }
        [Required]
        public virtual List<UserSectorDto> Sectors { get; set; }
    }
}
