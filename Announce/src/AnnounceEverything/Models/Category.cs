using System.ComponentModel.DataAnnotations;

namespace AnnounceEverything.Models
{
    public class Category 
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
    }
}
