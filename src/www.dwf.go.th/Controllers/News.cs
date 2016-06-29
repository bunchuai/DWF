using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace www.dwf.go.th.Controllers
{
    public class News : Controller
    {
        // GET: /<controller>/
        public IActionResult Public_News()
        {
            return View("Public_News/Public_News");
        }
    }
}
