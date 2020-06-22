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
        //查询
        [HttpGet]
        public List<AllotShowModel> ShowPageAllot(string AllotCode,  string WName, string Ename)
        {
            string sql = "select *from Allot join Commodity  on Allot.Sid=Commodity.Sid join Warehouse  on Allot.Wid=Warehouse.WId join ExportStoreroom on Allot.Eid=ExportStoreroom.EId where 1=1";
            if (!string.IsNullOrEmpty(AllotCode))
            {
                sql += $"and Allot.AllotCode like'{AllotCode}'";
            }
            if (!string.IsNullOrEmpty(WName))
            {
                sql += $"and Warehouse.WName like'{WName}'";
            }
            if (!string.IsNullOrEmpty(Ename))
            {
                sql += $"and ExportStoreroom.Ename like'{Ename}'";
            }
            return _Business.Select<AllotShowModel>(sql);
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