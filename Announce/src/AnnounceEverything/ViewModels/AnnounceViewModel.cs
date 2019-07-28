using AnnounceEverything.Data;
using AnnounceEverything.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnnounceEverything.ViewModels
{
    public class AnnounceViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; }

        public DateTime DateTime { get; set; }

        public int ConditionId { get; set; }

        [Required]
        public IEnumerable<SelectListItem> Condition { get; set; }

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
        public IEnumerable<SelectListItem> Category { get; set; }

        public int ProvinceId { get; set; }

        [Required]
        public IEnumerable<SelectListItem> Province { get; set; }


        public string UserId { get; set; }

        [Required]
        public AppUser User { get; set; }


    }
}
