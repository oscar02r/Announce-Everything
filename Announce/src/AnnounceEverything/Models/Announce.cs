using AnnounceEverything.Data;
using System;

namespace AnnounceEverything.Models
{
    public class Announce
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public Condition Condition { get; set; }

        public Decimal Price { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public Category Category { get; set; }

        public Province Province { get; set; }

        public AppUser User { get; set; }

    }
}
