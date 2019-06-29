
using System.ComponentModel.DataAnnotations;

namespace AnnounceEverything.Models
{
    public class Condition
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
    }
}
