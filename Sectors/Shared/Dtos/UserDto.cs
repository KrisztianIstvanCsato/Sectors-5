using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string Name { get; set; }

        //[Required(ErrorMessage = "Your agreement is required")]
        public bool Agreed { get; set; }
        public List<UserSectorDto> Sectors { get; set; }
    }
}
