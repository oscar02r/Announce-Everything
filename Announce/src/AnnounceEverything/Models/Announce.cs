using AnnounceEverything.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnnounceEverything.Models
{
    public class Announce
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; }

        public DateTime DateTime { get; set; }

        public int ConditionId { get; set; }

        [Required]
        public Condition Condition { get; set; }

        [Required]
        [MinLength(3)]
        public float Price { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [MaxLength(50)]
        public Category Category { get; set; }

        public int ProvinceId { get; set; }

        [Required]
        public Province Province { get; set; }

        
        public string UserId { get; set; }

        [Required]
        public AppUser User { get; set; }

    }
}
