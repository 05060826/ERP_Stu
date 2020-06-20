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

        [Route("showXiao")]
        [HttpGet]
        public List<SellModel> ShowXiao()
        {
            
            List<SellModel> list = DapperHelper<SellModel>.GetAll("select * from Sell");
            return list;
        }


        [Route("show")]
        [HttpGet]
        public List<OutStock> Show(string where=null,string date=null,int xiao=-1,int shou=-1 )
        {
            string sql = "select* from Clear a join Client b on a.cliId = b.CLientId join Sell c on a.MId = c.SeId where 1=1" ;

            //select * from Clear a join Client b on a.cliId=b.CLientId join Sell c on a.MId=c.SeId where a.CleaNumber='CH20200616' and a.CTime='2020-06-16 00:00:00.000' and c.SeId=1 and a.CState=1
            if (!string.IsNullOrWhiteSpace(where))
            {
                sql += "and a.CleaNumber='" + where + "' ";

            }
            if (!string.IsNullOrWhiteSpace(date))
            {
                sql += "and  a.CTime='" + date + "' ";

            }
            if (xiao != -1)
            {
                sql += "and  c.SeId='" + xiao + "' ";
            }
            if (shou != -1)
            {
                sql += "and  a.CState='" + shou + "' ";
            }


            //var list = _Business.Select<OutStock>("select * from Clear a join Client b on a.ClientId=b.CLientId");
            List<OutStock> list = DapperHelper<OutStock>.GetAll(sql);
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