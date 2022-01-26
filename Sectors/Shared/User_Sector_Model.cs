using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sectors.Shared
{
    public class User_Sector_Model
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SectorId { get; set; }
        public UserModel User { get; set; }
        public SectorModel Sector { get; set; }
    }
}
