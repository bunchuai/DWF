﻿using System;
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

        [HttpGet]
        public IActionResult AjaxVideo(string link)
        {

            string Ex = "Has error!";
            try
            {
                string html = "";
                html += "<iframe width='653' height='332' src='" + link + "&autoplay=1' frameborder='0' allowfullscreen></iframe>";
                return Json(html);
            }
            catch (Exception ex) {

                return View(ex);
            }
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
