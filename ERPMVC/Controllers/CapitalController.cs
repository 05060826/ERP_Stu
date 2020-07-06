using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ERPMVC.Controllers
{
    public class CapitalController : Controller
    {
        public IActionResult Receipt()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult UpdReceipt()
        {
            return View();
        }
        public IActionResult PayMent()
        {
            return View();
        }
        public IActionResult AddPayMent()
        {
            return View();
        }
        public IActionResult UpdPayMent()
        {
            return View();
        }
        public IActionResult CapitalStatement()
        {
            return View();
        }
    }
}