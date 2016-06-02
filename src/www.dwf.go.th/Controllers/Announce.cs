using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace www.dwf.go.th.Controllers
{
    public class Announce : Controller
    {

        /* --- จัดซื้อจัดจ้าง ---*/
        public IActionResult purchase()
        {

            return View("purchase/purchase");
        }
        [HttpGet]
        public IActionResult single_page_purchase(int ID, string Description)
        {

            ViewBag.description = Description;
            return View("purchase/single_page_purchase");
        }
        /* --- */

        /* --- สมัครงาน ---*/
        public IActionResult register_job()
        {

            return View("register/register_job");
        }
        [HttpGet]
        public IActionResult singleRegister(int ID)
        {

            String massage = "link สมัครงาน";
            return View("register/singleRegister");
        }
        /* --- */
    }
}
