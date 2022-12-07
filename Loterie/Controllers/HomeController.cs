using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Loterie.Data;
using Loterie.Models;
using System.Diagnostics;

namespace Loterie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LoterieContext _context;

        public HomeController(ILogger<HomeController> logger, LoterieContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: Sessions
        public async Task<IActionResult> Index()
        {
            return _context.Session != null ?
                        View(await _context.Session.ToListAsync()) :
                        Problem("Entity set 'LoterieContext.Session'  is null.");
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

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