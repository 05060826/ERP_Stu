using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Model.Model;
using Model.OutModel;
namespace ERPAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AllotController : ControllerBase
    {
        Allot_Business _Business = null;
        public AllotController()
        {
            _Business = new Allot_Business();
        }
        //分页
        [HttpGet]
        public List<AllotShowModel> ShowPageAllot(string AllotCode, DateTime Sage, string WName, string Ename, int pageindex = 1, int pagesize = 3)
        {
            var list = _Business.ShowPageAllot(AllotCode, Sage, WName, Ename, pageindex,pagesize);
            var b = list.Skip((pageindex - 1) * pagesize).Take(pagesize);
            List<AllotShowModel> model = new List<AllotShowModel>();
            
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