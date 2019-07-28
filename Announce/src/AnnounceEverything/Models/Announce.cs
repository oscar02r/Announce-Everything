using AnnounceEverything.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnnounceEverything.Models
{
    public class Announce
    {
        public int Id { get; set; }

        [Required]
       // [StringLength(50)]
        public string Title { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public int ConditionId { get; set; }
        //[ForeignKey("ConditionId")]

        public Condition Condition { get; set; }

        [Required]
      //  [MinLength(3)]
        public float Price { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [MaxLength(50)]
        public Category Category { get; set; }

        [Required]
        public int ProvinceId { get; set; }

        public Province Province { get; set; }

        [Required]
        public string UserId { get; set; }

        public AppUser User { get; set; }

    }
}
