using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AnnounceEverything.Models;
using Microsoft.AspNetCore.Identity;

namespace AnnounceEverything.Data
{
    public class AppUser : IdentityUser
    {
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }
       
        public TypeUser TypeUser { get; set; }
    }
}
