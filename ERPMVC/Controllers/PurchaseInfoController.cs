using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ERPMVC.Controllers
{
    public class PurchaseInfoController : Controller
    {
        public IActionResult Purchas()
        {
            return View();
        }

        public IActionResult AddPurchas()
        {
            return View();
        }

        public IActionResult UpdatePurchas(int rid)
        {

            ViewBag.rid = rid;
            return View();
        }

        public IActionResult ShowUpdatePurchas()
        {
            return View();
        }
    }
}
