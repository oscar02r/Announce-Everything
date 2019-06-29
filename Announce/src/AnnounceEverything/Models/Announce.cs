using AnnounceEverything.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnounceEverything.Models
{
    public class Announce
    {
        public int Id{ get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public AppUser User { get; set; }

    }
}
