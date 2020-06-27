using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using DataAccess.Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.CapitalModel;
using Model.PuchasesInfoModel;
using Newtonsoft.Json;


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
        public string GetReceiptData(DateTime? dateTime=null,string where="")
        {
            string sql = "select * from Receipt r join Clear c on r.ClearId=c.ClearId join Client cl on r.ClientId=cl.CLientId where 1=1 and r.isstate=1 ";
            if (!string.IsNullOrEmpty(where))
            {
                sql += $" and r.ReceiptCode='{where}' ";
            }
            if (dateTime!=null)
            {
                sql += $" and RTime='{dateTime}'";
            }
            List<DtoReceiptModel> list= _business.Select<DtoReceiptModel>(sql);
            Dictionary<string, object> obj = new Dictionary<string, object>();

            //前台通过key值获得对应的value值
            obj.Add("code", 0);
            obj.Add("msg", "");
            obj.Add("count", list.Count);
            obj.Add("data", list);
            return JsonConvert.SerializeObject(obj);
        }
        [HttpGet]
        public int DelReceiptData(int receiptId)
        {
            string sql = "update from  Receipt set isstate=0 where ReceiptId="+ receiptId + "";
            return _business.Delete(sql);
        }
        [HttpGet]
        public List<ClientModel> GetClientData()
        {
            string sql = "select * from Client";
            return _business.Select<ClientModel>(sql);
        }
        [HttpGet]
        public List<ClearModel> GetClearData(string clearNumber="")
        {
            string sql = "select * from Clear where 1=1 and CState=0 ";
            if (!string.IsNullOrEmpty(clearNumber))
            {
                sql += " and CleaNumber='" + clearNumber+ "'";
            }
            return _business.Select<ClearModel>(sql);
        }
        [HttpPost]
        public int AddReceiptData(ReceiptModel model)
        {
            model.RTime = DateTime.Now;
            model.IsState = 1;
            string sql = $"insert into Receipt (ReceiptCode,ClientId,ClearId,CNumber,Aid,RTime,Remark,IsState) values('{model.ReceiptCode}','{model.ClientId}','{model.ClearId}','{model.CNumber}','{model.Aid}','{model.RTime}','{model.Remark}','{model.IsState}')";
            return DapperHelper<ReceiptModel>.CRD(sql);
        }


        [HttpGet]
        public string GetPayMentData(DateTime? dateTime = null, string where = "")
        {
            string sql = "select * from PayMent r join Purchase c on r.ReceIptsId=c.ReceIptsId join Client cl on r.ClientId=cl.CLientId where 1=1 and r.isstate=1 ";
            if (!string.IsNullOrEmpty(where))
            {
                sql += $" and r.PaymentCode='{where}' ";
            }
            if (dateTime != null)
            {
                sql += $" and RTime='{dateTime}'";
            }
            List<DtoPayMentModel> list= _business.Select<DtoPayMentModel>(sql);
            Dictionary<string, object> obj = new Dictionary<string, object>();

            //前台通过key值获得对应的value值
            obj.Add("code", 0);
            obj.Add("msg", "");
            obj.Add("count", list.Count);
            obj.Add("data", list);
            return JsonConvert.SerializeObject(obj);
        }
        [HttpGet]
        public int DelPayMentData(int paymentId)
        {
            string sql = "update from  PayMent set isstate=0 where PaymentId=" + paymentId + "";
            return _business.Delete(sql);
        }
        [HttpGet]
        public List<ClientModel> GetClientPData()
        {
            string sql = "select * from Client";
            return _business.Select<ClientModel>(sql);
        }
        [HttpGet]
        public List<PurchModel> GetPurchaseData(string receIptsCode = "")
        {
            string sql = "select * from Purchase where 1=1 ";
            if (!string.IsNullOrEmpty(receIptsCode))
            {
                sql += " and ReceIptsCode='" + receIptsCode + "'";
            }
            return _business.Select<PurchModel>(sql);
        }
        [HttpPost]
        public int AddPayMentData(PaymentModel model)
        {
            model.RTime = DateTime.Now;
            model.IsState = 1;
            string sql = $"insert into PayMent (PaymentCode,ClientId,ReceIptsId,CNumber,Aid,RTime,Remark,IsState) values('{model.PaymentCode}','{model.ClientId}','{model.ReceIptsId}','{model.CNumber}','{model.Aid}','{model.RTime}','{model.Remark}','{model.IsState}')";
            return DapperHelper<PaymentModel>.CRD(sql);
        }
    }
}