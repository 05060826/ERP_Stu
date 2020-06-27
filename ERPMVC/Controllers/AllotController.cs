using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ERPMVC.Controllers
{
    public class AllotController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult ShowChecks()
        {
            return View();
        }
        public IActionResult Forms()
        {
            return View();
        }
        public IActionResult CreateAllot()
        {
            return View();
        }
        public IActionResult Try()
        {
            return View();
        }

    }
}