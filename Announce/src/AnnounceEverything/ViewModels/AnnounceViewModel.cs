using AnnounceEverything.Data;
using AnnounceEverything.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnnounceEverything.ViewModels
{
    public class AnnounceViewModel : Announce
    {
        //[Required]
        //[StringLength(50, MinimumLength = 5)]
        //public string Title { get; set; }

        //[Required]
        //public Condition Condition { get; set; }

        //[Required]
        //public float Price { get; set; }

        //[MaxLength(300)]
        //public string Description { get; set; }

        //[Required]
        //[MaxLength(100)]
        //public string Image { get; set; }

        //[Required]
        //[MaxLength(50)]
        //public Category Category { get; set; }

        //[Required]
        //public Province Province { get; set; }

        //[Required]
        //public AppUser User { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }
    }
}
