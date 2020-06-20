using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.CapitalModel;

namespace ERPAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CapitalController : ControllerBase
    {
        private IBaseBusiness _business;
        public CapitalController(IBaseBusiness business)
        {
            _business = business;
        }
        [HttpGet]
        public List<DtoReceiptModel> GetReceiptData(DateTime? dateTime=null,string where="")
        {
            string sql = "select * from Receipt r join Clear c on r.ClearId=c.ClearId join Client cl on r.ClientId=cl.CLientId where 1=1";
            if (!string.IsNullOrEmpty(where))
            {
                sql += $" and r.ReceiptCode='{where}' ";
            }
            if (dateTime!=null)
            {
                sql += $" and RTime='{dateTime}'";
            }
            return _business.Select<DtoReceiptModel>(sql);
        }
        [HttpGet]
        public int DelReceiptData(int receiptId)
        {
            string sql = "delete from  Receipt where ReceiptId="+ receiptId + "";
            return _business.Delete(sql);
        }
    }
}