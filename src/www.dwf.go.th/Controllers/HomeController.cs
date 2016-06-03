using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace www.dwf.go.th.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Intralogin()
        {
            return View("Intralogin");
        }

        public IActionResult Help()
        {
            return View("Help");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
