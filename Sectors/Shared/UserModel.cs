using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sectors.Shared
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter a name")]
        [StringLength(50, ErrorMessage = "The name is too long")]
        public string Name { get; set; }
        // public List<SectorModel> Sectors { get; set; } // Data Transfer Object / Relationship property

        [Required(ErrorMessage = "Your agreement is required")]
        public bool Agreed { get; set; }

        //Navigation prop
        public List<User_Sector_Model> UserSectors { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Please select at least {1} sector you are currently working in!")]
        public int[] SelectedSectors { get; set; }
    }
}
