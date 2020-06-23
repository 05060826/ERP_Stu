using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;
using Model.AarehouseModel;
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
        //查询
        [HttpGet]
        public List<AllotShowModel> ShowPageAllot(string AllotCode=null, string WName=null, string Ename=null)
        {
            var list = _Business.ShowPageAllot(AllotCode,WName,Ename);
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
        //盘点表数据
        public List<CheckShowModel> CheckShowModel(string WName,string Ename)
        {
            var list = _Business.CheckShowModel(WName,Ename);
            return list;
        }
    }
}