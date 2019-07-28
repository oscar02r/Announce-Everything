using AnnounceEverything.Data;
using AnnounceEverything.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnnounceEverything.ViewModels
{
    public class AnnounceViewModel
    {
        [Required]
        // [StringLength(50, MinimumLength = 5)]
        public string Title { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        public int ConditionId { get; set; }
       // [ForeignKey("ConditionId")]

        public IEnumerable<SelectListItem> Condition { get; set; }

        [Required]
        //[MinLength(3)]
        public float Price { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        [Required]
        public int CategoryId { get; set; }
       
        [MaxLength(50)]
        public IEnumerable<SelectListItem> Category { get; set; }

        [Required]
        public int ProvinceId { get; set; }

        public IEnumerable<SelectListItem> Province { get; set; }

       // public string Date { get; set; }
        //public string Time { get; set; }

       /* public DateTime GetFullDate(){
            

            return DateTime.Parse($"{Date} {Time}");
        }*/


    }
}
