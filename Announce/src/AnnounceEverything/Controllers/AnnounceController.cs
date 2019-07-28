using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AnnounceEverything.Models;
using AnnounceEverything.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnnounceEverything.Controllers
{
    public class AnnounceController : Controller
    {
        private readonly DataContext _context;

        public AnnounceController(DataContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Create()
        {
            var category = _context.Categories.ToList();
            var condition = _context.Conditions.ToList();
            var province = _context.Provinces.ToList();

            //ViewBag.categoriesid = new SelectList(category,"Id","Name");

            var vm = new AnnounceViewModel
            {
                Category = new SelectList(category, "Id", "Name"),
                Condition = new SelectList(condition, "Id", "Name"),
                Province = new SelectList(province, "Id", "Name")
            };
            return View(vm);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(AnnounceViewModel vm)
        {
            if (ModelState.IsValid)
            {
                //var userId = User.Identity.GetUserId();
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var model = new Announce
                {
                    UserId = userId,
                    Title = vm.Title,
                    Price = vm.Price,
                    ConditionId = vm.ConditionId,
                    CategoryId = vm.CategoryId,
                    DateTime = DateTime.Now,
                    Image = vm.Image,
                    ProvinceId = vm.ProvinceId,
                    Description = vm.Description
                 
                };

                _context.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index","Home");
            }

            // return RedirectToAction("Create","Announce");
            return View();
        }
    }
}