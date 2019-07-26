using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnnounceEverything.Models
{
    public class Province
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}
