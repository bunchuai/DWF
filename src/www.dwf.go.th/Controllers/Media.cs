using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace www.dwf.go.th.Controllers
{
    public class Media : Controller
    {
        public IActionResult media()
        {
            return View("media");
        }
    }
}
