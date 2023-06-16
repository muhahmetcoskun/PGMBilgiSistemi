using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User : IdentityUser
    {
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
       // public override String? UserName { get; set; }
        //public String? Password { get; set; }
        //public int? Role { get; set; }
        public String? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
