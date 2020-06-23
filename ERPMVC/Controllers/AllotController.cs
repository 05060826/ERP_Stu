using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ERPMVC.Controllers
{
    public class AllotController : Controller
    {
        public IActionResult ShowTable()
        {
            return View();
        }
        public IActionResult ADD()
        {
            return View();
        }
        public IActionResult Checks()
        {
            return View();
        }
        public IActionResult Forms()
        {
            return View();
        }

    }
}