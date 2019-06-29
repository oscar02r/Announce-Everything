
using System.ComponentModel.DataAnnotations;

namespace AnnounceEverything.Models
{
    public class UserKind
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
    }
}
