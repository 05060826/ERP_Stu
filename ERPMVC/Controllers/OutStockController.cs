using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.OutModel;

namespace ERPMVC.Controllers
{
    public class OutStockController : Controller
    {
        //出货显示功能
        public IActionResult Index()
        {
            return View();
        }
        //新增出货功能
        public IActionResult Create()
        {
            return View();
        }
        //修改出货功能
        public IActionResult Update(int id=-1)
        {

            ViewBag.Id = id;
            return View();
        }

        //新增退货功能
        public IActionResult Tui()
        {
            return View();
        }
        //显示所有退货功能
        public IActionResult AllTui()
        {
            return View();
        }
    }
}