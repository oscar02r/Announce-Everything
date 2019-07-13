using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AnnounceEverything.Data;
using AnnounceEverything.Models;
using AnnounceEverything.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnnounceEverything.Controllers
{
    public class AnnouncesController : Controller
    {
        private readonly DataContext _context;

        public AnnouncesController(DataContext datacontext)
        {
            _context = datacontext;
        }

        [Authorize]
        public IActionResult Create()
        {
            var category = _context.Categories.ToList();
            var conditon = _context.Conditions.ToList();
            var province = _context.Provinces.ToList();

            //ViewBag.categoriesid = new SelectList(category,"Id","Name");

            var vm = new AnnounceViewModel
            {
                Category = new SelectList(category,"Id", "Name"),
                Condition = new SelectList(conditon, "Id", "Name"),
                Province = new SelectList(province, "Id", "Name"),
            };
            return View(vm);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(AnnounceViewModel vm)
        {
           
     
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = new Announce
            {
              UserId = userId,
              Title = vm.Title,
              DateTime = vm.GetFullDate(),
              CategoryId = vm.Categoryid,
              ProvinceId = vm.ProvinceId,
              Image = vm.Image,
              Price = vm.Price,
              Description = vm.Description,
              ConditionId = vm.ConditionId
            };

            _context.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Index","Home");
        }

    }
}