﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.OutModel;

namespace ERPMVC.Controllers
{
    public class OutStockController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult update(int id=-1)
        {

            ViewBag.Id = id;
            return View();
        }
    }
}