﻿using HotelShowcaseWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HotelShowcaseWebApp.Data;


namespace HotelShowcaseWebApp.Controllers {
    public class HomeController : Controller {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context) {
            _context = context;
        }

        public IActionResult Index() {
            List<Hotele> hotele = _context.Hotele.ToList();
            return View(hotele);
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}