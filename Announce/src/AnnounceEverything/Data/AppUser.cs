using AnnounceEverything.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AnnounceEverything.Data
{

    public class AppUser : IdentityUser
    {
        public int UserKindId { get; set; }
        [Required]
        public UserKind Kind { get; set; }
    }
}
