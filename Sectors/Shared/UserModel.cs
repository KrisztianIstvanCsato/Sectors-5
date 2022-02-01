using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sectors.Shared
{
    public class UserModel
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Enter a name")]
        //[MinLength(3, ErrorMessage = "The name is too short")]
        //[StringLength(50, ErrorMessage = "The name is too long")]
        public string Name { get; set; }
        // public List<SectorModel> Sectors { get; set; } // Data Transfer Object / Relationship property

        [Required(ErrorMessage = "Your agreement is required")]
        public bool Agreed { get; set; }

        ////Navigation prop
        //[Required(ErrorMessage = "Please select at least one sector")]
        //[MinLength(1)]
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public List<User_Sector_Model>? UserSectors { get; set; }
    }
}
