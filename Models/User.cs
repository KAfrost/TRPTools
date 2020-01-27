using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TRPTools.Models
{
    public class User
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get;  set; }

        [Required]
        public string Verify { get; set; }
        [Required]
        public string Email { get; set; }

        public int UserID { get; set; }

        public IList<Order> Orders { get; set; }



    }
}
