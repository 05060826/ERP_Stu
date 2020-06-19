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
    }
}