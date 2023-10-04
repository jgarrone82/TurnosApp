using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TurnosApp.Models;

namespace TurnosApp.Controllers
{
    [Route("[controller]")]
    public class SpecialtyController : Controller
    {
        private readonly ILogger<SpecialtyController> _logger;
        private readonly TurnosContext _context;

        public SpecialtyController(ILogger<SpecialtyController> logger, TurnosContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Specialties.ToList());
        }

/*         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        } */
    }
}