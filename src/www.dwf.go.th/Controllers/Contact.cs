using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace www.dwf.go.th.Controllers
{
    public class Contact : Controller
    {
        // GET: /<controller>/
        // ส่วนกลาง
        public IActionResult Center()
        {
            return View();
        }

        // ส่วนภูมิภาค
        public IActionResult Region()
        {
            return View();
        }

        // ถาม-ตอบ
        public IActionResult QA()
        {
            return View();
        }

        // คำถามที่พบบ่อย
        public IActionResult FAQ()
        {
            return View();
        }
    }
}
