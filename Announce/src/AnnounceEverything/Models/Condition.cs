
using System.ComponentModel.DataAnnotations;

namespace AnnounceEverything.Models
{
    public class Condition
    {
        public byte Id { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }
    }
}
