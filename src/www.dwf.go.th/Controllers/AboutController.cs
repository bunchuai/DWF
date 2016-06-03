using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace www.dwf.go.th.Controllers
{
    public class AboutController : Controller
    {
        // GET: /<controller>/
        // พระบรมราโชวาท
        public IActionResult Royalguidance()
        {
            return View();
        }

        // สารจากนายกรัฐมนตรี
        public IActionResult MessagePresident()
        {
            return View();
        }

        // ประวัติความเป็นมา
        public IActionResult History()
        {
            return View();
        }

        // วิสัยทัศน์ พันธกิจหลัก
        public IActionResult Vision()
        {
            return View();
        }

        // ภารกิจหลัก
        public IActionResult Mission()
        {
            return View();
        }

        // ทำเนียบกรม
        public IActionResult PalaceDep()
        {
            return View();
        }

        // ทำเนียบผู้อำนวยการ
        public IActionResult PalaceDirector()
        {
            return View();
        }

        // ผู้บริหารฝ่ายการเมือง พม.
        public IActionResult Policy_Manager()
        {
            return View();
        }

        // ผู้บริหารฝ่ายข้าราชการประจำ พม.
        public IActionResult Official_Manager()
        {
            return View();
        }

        // ผู้บริหาร
        public IActionResult Manager()
        {
            return View();
        }

        // โครงสร้าง และ อัตรากำลัง
        public IActionResult Structure()
        {
            return View();
        }

        // คำรับรองการปฏิบัติราชการ
        public IActionResult Guarantee()
        {
            return View();
        }

        // ค่านิยมองค์กร
        public IActionResult Core_Values()
        {
            return View();
        }

        // คณะกรรมการ
        public IActionResult Board()
        {
            return View();
        }
    }
}
