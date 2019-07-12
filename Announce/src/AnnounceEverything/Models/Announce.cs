using AnnounceEverything.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace AnnounceEverything.Models
{
    public class Announce
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50,MinimumLength = 5)]
        public string Title { get; set; }

        public DateTime DateTime { get; set; }


        [Required]
        public Condition Condition { get; set; }

        [Required]
        public float Price { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        [Required]
        [MaxLength(50)]
        public Category Category { get; set; }

        [Required]
        public Province Province { get; set; }

        [Required]
        public AppUser User { get; set; }

    }
}
