using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManageItLinux.Database;

namespace WebApplicationBasic.Controllers
{
    public class HomeController : Controller
    {

        private readonly ManageItContext _context;

        public HomeController(ManageItContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
