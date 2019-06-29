using AnnounceEverything.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AnnounceEverything.Data
{

    public class AppUser : IdentityUser
    {
        public Province Province { get; set; }
        public string Telephone { get; set; }
        public UserKind Kind { get; set; }
    }
}
