using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnnounceEverything.Data;
using AnnounceEverything.ViewModels;
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

        public IActionResult Index()
        {
            return View();
        }

    }
}