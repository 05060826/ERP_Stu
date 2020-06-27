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
using Newtonsoft.Json;

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
        //查询盘点
        [HttpGet]
        public string ShowPageAllot(string AllotCode=null, string WName=null, string Ename=null)
        {
            var list = _Business.ShowPageAllot(AllotCode,WName,Ename);
            Dictionary<string, object> obj = new Dictionary<string, object>();
            obj.Add("code", 0);
            obj.Add("msg", "");
            obj.Add("count", list.Count);
            obj.Add("data", list);
            return JsonConvert.SerializeObject(obj);
        }
        //报表查询
        [HttpGet]
        public List<ShowAll> ShowFrom()
        {
            var list = _Business.ShowFrom();

            return list;
        }
        //添加盘点
        [HttpPost]
        public int CeeateAllot(Model.AllotModel Allot)
        {
            var str = _Business.CeeateAllot(Allot);
            return str;
        }
        //修改/删除
        [HttpPost]
        public int Update(int Id)
        {
            return _Business.UpdateAll(Id);
        }

        [HttpGet]
        //盘点表数据
        public string CheckShowModel(string WName,string Ename)
        {
            var list = _Business.CheckShowModel(WName,Ename);
            Dictionary<string, object> obj = new Dictionary<string, object>();
            obj.Add("code", 0);
            obj.Add("msg", "");
            obj.Add("count", list.Count);
            obj.Add("data", list);
            return JsonConvert.SerializeObject(obj);
            
        }
        [HttpGet]
        //下拉商品
        public List<CommodityModel> ShowComm()
        {
            var clist = _Business.ShowComm();
            return clist;
            
        }
        [HttpGet]
        //下拉入库
        public List<WarehouseModel> ShowWare()
        {
            var wlist = _Business.ShowWare();
            return wlist;
        }
        [HttpGet]
        //下拉出库
        public List<ExportStoreroomModel> ShowExportSto()
        {
            var elist = _Business.ShowExportSto();
            return elist;
           
        }
    }
}