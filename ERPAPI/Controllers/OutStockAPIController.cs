using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using DataAccess.Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.OutModel;

namespace ERPAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class OutStockAPIController : ControllerBase
    {
        BaseBusiness _Business = null;
        public OutStockAPIController()
        {
            _Business = new BaseBusiness();
        }
        [Route("show")]
        [HttpGet]
        public List<OutStock> Show()
        {
            //var list = _Business.Select<OutStock>("select * from Clear a join Client b on a.ClientId=b.CLientId");
            List<OutStock> list = DapperHelper<OutStock>.GetAll("select * from Clear a join Client b on a.cliId=b.CLientId");
            return list;
        }

        [Route("showIns")]
        [HttpGet]
        public List<Goods> ShowIns()
        {
            //var list = _Business.Select<OutStock>("select * from Clear a join Client b on a.ClientId=b.CLientId");
            List<Goods> list = DapperHelper<Goods>.GetAll("select a.ClearId, b.SName,b.Units,c.WName,a.Number,a.SellMoney,a.Discount,a.SMoney from Clear a join Commodity b on a.SId=b.Sid join Warehouse c on b.WId= c.WId");
            
            return list;
        }

        [Route("insert")]
        [HttpPost]
        public int Add([FromBody]ClearModel clear)
        {
            int count = 0;
            count = _Business.Add<ClearModel>(clear);

            return count;


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