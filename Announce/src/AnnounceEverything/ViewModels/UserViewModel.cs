using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnounceEverything.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public IEnumerable <SelectListItem> UserKind { get; set; }
    }
}
