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

        public int ConditionId { get; set; }

        [Required]
        public IEnumerable<SelectListItem> Condition { get; set; }

        [Required]
        public float Price { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        [Required]
        [MaxLength(50)]
        public int Categoryid { get; set; }
        public IEnumerable<SelectListItem> Category  { get; set; }

        public int ProvinceId { get; set; }
        [Required]
        public IEnumerable<SelectListItem> Province { get; set; }

        [Required]
        public AppUser User { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse($"{Date} {Time}");
        }
    }
}
