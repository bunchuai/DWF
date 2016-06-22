using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace www.dwf.go.th.Controllers
{
    public class Complaint : Controller
    {
        // GET: /<controller>/
        // แบบที่ 1
        public IActionResult Index()
        {
            return View();
        }

        // แบบที่ 2
        public IActionResult Complaint2()
        {
            return View();
        }
    }
}
