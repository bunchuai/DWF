using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace www.dwf.go.th.Controllers
{
    public class CIO : Controller
    {
        // ผู้บริหารเทคโนโลยีระดับสูง
        public IActionResult CIOEXE()
        {
            return View();

        }

        //รายชื่อฝ่ายกระเมือง
        public IActionResult PFKM()
        {
            return View();
        }

        //รายชื่อฝ่ายข้าราชการประจำ
        public IActionResult PFICT()
{
    return View();
        }
        //รายชื่อฝ่ายผู้บริหารกรมกิจการสตรีและสถาบันครอบครัว
        public IActionResult PFEXE()
        {
            return View();

        }
        // วิสัยทัศน์
        public IActionResult Vision()
        {
            return View();

        }

        // ติดต่อ
        public IActionResult Contact()
        {
            return View();

        }


        // ProfileKM //
        [HttpGet]
        public IActionResult KM01()
        {
            return View("ProfileKM/KM01");
        }

        // สารจากผู้บริหารประเทศ //
        [HttpGet]
        public IActionResult ministry()
        {
            return View();
        }

        // ติดต่อสค. //
        [HttpGet]
        public IActionResult contact()
        {
            return View();
        }

        [HttpGet]
        public IActionResult KM02()
        {
            return View("ProfileKM/KM02");
        }
        [HttpGet]
        public IActionResult KM03()
        {
            return View("ProfileKM/KM03");
        }
        [HttpGet]
        public IActionResult KM04()
        {
            return View("ProfileKM/km04");
        }
        [HttpGet]
        public IActionResult KM05()
        {
            return View("ProfileKM/KM05");
        }
        // End Profile KM //
        // Profile ICT//
        [HttpGet]
        public IActionResult ICT01()
        {
            return View("ProfileICT/ICT01");
        }
        [HttpGet]
        public IActionResult ICT02()
        {
            return View("ProfileICT/ICT02");
        }
        [HttpGet]
        public IActionResult ICT03()
        {
            return View("ProfileICT/ICT03");
        }
        [HttpGet]
        public IActionResult ICT04()
        {
            return View("ProfileICT/ICT04");
        }
        [HttpGet]
        public IActionResult ICT05()
        {
            return View("ProfileICT/ICT05");
        }
        [HttpGet]
        public IActionResult ICT06()
        {
            return View("ProfileICT/ICT06");
        }
        [HttpGet]
        public IActionResult ICT07()
        {
            return View("ProfileICT/ICT07");
        }
        [HttpGet]
        public IActionResult ICT08()
        {
            return View("ProfileICT/ICT08");
        }
        [HttpGet]
        public IActionResult ICT09()
        {
            return View("ProfileICT/ICT09");
        }
        [HttpGet]
        public IActionResult ICT10()
        {
            return View("ProfileICT/ICT10");
        }
        [HttpGet]
        public IActionResult ICT11()
        {
            return View("ProfileICT/ICT11");
        }
        // End Profile ICT//
    }
}