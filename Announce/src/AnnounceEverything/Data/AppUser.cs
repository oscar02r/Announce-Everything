using AnnounceEverything.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AnnounceEverything.Data
{

    public class AppUser : IdentityUser
    {
        [Required]
        public Province Province { get; set; }

        [Required]
        public string Telephone { get; set; }

        [Required]
        public UserKind Kind { get; set; }
    }
}
