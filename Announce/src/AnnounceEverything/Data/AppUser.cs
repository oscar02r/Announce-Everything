using AnnounceEverything.Models;
using Microsoft.AspNetCore.Identity;

namespace AnnounceEverything.Data
{

    public class AppUser : IdentityUser
    {
        public Kind Type { get; set; }

        public string Telephone { get; set; }

        public Province Province { get; set; }
    }
}
