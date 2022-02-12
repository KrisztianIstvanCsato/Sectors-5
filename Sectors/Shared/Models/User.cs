using Sectors.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public bool Agreed { get; set; }

        public virtual List<UserSector> Sectors { get; set; }
    }
}
