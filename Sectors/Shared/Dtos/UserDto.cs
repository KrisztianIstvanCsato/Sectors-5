using System.ComponentModel.DataAnnotations;

namespace Sectors.Shared.Dtos
{
    public class UserDto
    {
        public UserDto()
        {
            SectorIds = new List<int>();
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
        [MinLength(1, ErrorMessage = "You should provide at least one sector!")]
        public List<int> SectorIds { get; set; }
    }
}
