﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ERPMVC.Controllers
{
    //综合报表
    public class SynthesizeController : Controller
    {
        //全国
        public IActionResult Country()
        {
            return View();
        }
        //采购
        public IActionResult Purchase()
        {
            return View();
        }
        
    }
}