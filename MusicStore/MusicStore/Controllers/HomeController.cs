using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Data;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Song()
        {
            return View(_context.Song.Where(m => m.IsActive==true).ToList());
        }
        public IActionResult Albums()
        {
            return View(_context.Song.GroupBy(x => x.Album).Select(grp =>grp.First()).ToList());
        }

        public IActionResult Index()
        {
            return View(_context.Song.Where(m => m.IsFeatured).ToList());
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
