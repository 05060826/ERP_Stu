using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;

namespace ERPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllotController : ControllerBase
    {
        Allot_Business _Business = null;
        public AllotController()
        {
            _Business = new Allot_Business();
        }

        [HttpGet]
        public List<AllotModel> ShowPage(string AllotCode, int Sage, string WName, string WName1, int pageIndex, int pagesize)
        {
            var list = _Business.ShowPage(AllotCode,Sage,WName,WName1,pageIndex,pagesize);
            return list;
        }
        [HttpPost]
        public void ADD()
        {

        }
        [HttpDelete]
        public void Delete()
        {

        }
        [HttpPut]
        public void Update()
        {

        }
    }
}