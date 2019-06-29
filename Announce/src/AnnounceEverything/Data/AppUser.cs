using AnnounceEverything.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AnnounceEverything.Data
{

    public class AppUser : IdentityUser
    {
        [Required]
        public UserKind Type { get; set; }

        [Required]
        public string Telephone { get; set; }

        [Required]
        public Province Province { get; set; }
    }
}
