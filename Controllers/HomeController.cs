using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Collections;

namespace cross_platform_webapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = RuntimeInformation.OSDescription + " " + RuntimeInformation.OSArchitecture.ToString();
            ViewData["Framework"] = RuntimeInformation.FrameworkDescription;
            ViewData["ProcessArchitecture"] = RuntimeInformation.ProcessArchitecture;
            ViewBag.EnviornmentVariables = System.Environment.GetEnvironmentVariables();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
