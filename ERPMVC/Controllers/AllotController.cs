﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ERPMVC.Controllers
{
    public class AllotController : Controller
    {
       
        public IActionResult ShowTaA()
        {
            return View();
        }
        public IActionResult CreateAllot()
        {
            return View();
        }

        public IActionResult ShowChecks()
        {
            return View();
        }

        public IActionResult FormSum()
        {
            return View();
        }
    }
}