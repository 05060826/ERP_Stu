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
        //删除出货
        [Route("shan")]
        [HttpGet]
        public List<OutStock> outShan(int shanId)
        {
            string sql = $"update Clear set IsState=0 where ClearId={shanId}";
            int count = DapperHelper<ClearModel>.CRD(sql);
            List<OutStock> outs = null;
            if (count > 0)
            {  
                 outs=Show(3,1).list;                
            }          
            return outs;            
        }

        //显示销售人员
        [Route("showXiao")]
        [HttpGet]
        public List<SellModel> ShowXiao()
        {
            List<SellModel> list = DapperHelper<SellModel>.GetAll("select * from Sell");
            return list;
        }

        //显示客户
        [Route("showClient")]
        [HttpGet]
        public List<ClientModel> ShowClient()
        {
            List<ClientModel> list = DapperHelper<ClientModel>.GetAll("select * from Client");
            return list;
        }

        //显示付款账户
        [Route("showPay")]
        [HttpGet]
        public List<AccountModel> ShowCount()
        {
            List<AccountModel> list = DapperHelper<AccountModel>.GetAll("select * from Account");
            return list;
        }
        //显示商品
        [Route("showCommind")]
        [HttpGet]
        public List<CommodityModel> ShowCang()
        {
            List<CommodityModel> list = DapperHelper<CommodityModel>.GetAll("select * from Commodity");
            return list;
        }
        
        //显示出货商品（可查询）
        [Route("show")]
        [HttpGet]
        public OutStockList Show(int pageSize,int pageNumber, string where=null,string date=null,int xiao=-1,int shou=-1 )
        {
            string sql = "select* from Clear a join Client b on a.cliId = b.CLientId join Sell c on a.MId = c.SeId where 1=1 and a.IsState=1";

            //select * from Clear a join Client b on a.cliId=b.CLientId join Sell c on a.MId=c.SeId where a.CleaNumber='CH20200616' and a.CTime='2020-06-16 00:00:00.000' and c.SeId=1 and a.CState=1
            if (!string.IsNullOrWhiteSpace(where))
            {
                sql += "and a.CleaNumber='" + where + "' ";

            }
            if (!string.IsNullOrWhiteSpace(date))
            {
                sql += "and  a.CTime='" + date + "' ";

            }
            if (xiao != -1 )
            {
                sql += "and  c.SeId='" + xiao + "' ";
            }
            if (shou != -1 )
            {
                sql += "and  a.CState='" + shou + "' ";
            }


            //var list = _Business.Select<OutStock>("select * from Clear a join Client b on a.ClientId=b.CLientId");
            List<OutStock> list = DapperHelper<OutStock>.GetAll(sql);
            OutStockList outStockList = new OutStockList();
            outStockList.list = list.Skip((pageNumber-1)*pageSize).Take(pageSize).ToList();
            outStockList.count = list.Count/pageSize + (list.Count%pageSize>0?1:0);
            return outStockList;
        }

        //显示出货页面的表格(可查询)
        [Route("showIns")]
        [HttpGet]
        public List<Goods> ShowIns(string client=null,int xiao=1,string date=null)
        {
            string sql = "select a.ClearId, b.SName,b.Units,c.WName,a.Number,a.SellMoney,a.Rate,a.SMoney from Clear a join Commodity b on a.SId=b.Sid join Warehouse c on b.WId= c.WId join Client d on a.CliId=d.CLientId where 1=1 ";

            if (!string.IsNullOrWhiteSpace(client))
            {
                sql += "and d.ClientName='" + client + "' ";

            }
            if (!string.IsNullOrWhiteSpace(date))
            {
                sql += "and  a.CTime='" + date + "' ";

            }
            if (xiao != -1)
            {
                sql += "and a.MId='" + xiao + "' ";
            }


            //select a.ClearId, b.SName,b.Units,c.WName,a.Number,a.SellMoney,a.Discount,a.SMoney from Clear a join Commodity b on a.SId=b.Sid join Warehouse c on b.WId= c.WId join Client d on a.CliId=d.CLientId where d.ClientName='测试客户1' where d.ClientName='测试客户1'
            List<Goods> list = DapperHelper<Goods>.GetAll(sql);
            
            return list;
        }

        //添加出货
        [Route("insert")]
        [HttpPost]
        public int Add([FromBody]Insert clear)
        {
          
            int count = 1;
            //客户Id
            int ClientId = DapperHelper<Insert>.GetId($"select CLientId from Client where ClientName='{clear.CliName}'");
            //销售人员Id
            int SellId= DapperHelper<Insert>.GetId($"select SeId from Sell where SeName='{clear.MName}'");
            //
            
            if ( ClientId== 0)
            {
                DapperHelper<Insert>.CRD($"insert Client values('{clear.CliName}')");
                ClientId = DapperHelper<Insert>.GetId($"select CLientId from Client where ClientName='{clear.CliName}'");
            }
            if (SellId == 0)
            {
                DapperHelper<Insert>.CRD($"insert Sell values('{clear.MName}')");
                SellId = DapperHelper<Insert>.GetId($"select SeId from Sell where SeName='{clear.MName}'");
            }
            if (clear.AId != -1 && clear.Sid != -1)
            { 
                string sql = $"insert Clear values('{clear.CleaNumber}',{ClientId},{SellId},{clear.Sid},{clear.Number},{clear.SellMoney},{clear.Rate},{clear.Discount},{clear.SMoney},'{clear.Addresses}','{clear.CTime}',{clear.AId},1,1)";
                count = DapperHelper<Insert>.CRD(sql);
            }

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