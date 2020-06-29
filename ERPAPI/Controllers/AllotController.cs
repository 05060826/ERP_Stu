using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using ERPAPI.DatasModel;
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
        //查询调拨
        [HttpGet]
        public PageShowAllot ShowPageAllot(string AllotCode=null, string WName=null, string Ename=null, int pageIndex = 1, int pageSize = 3)
        {
            var list = _Business.ShowPageAllot();
            
            if (AllotCode != null)
            {
                list = list.Where(m => m.AllotCode.Contains(AllotCode)).ToList();
            }
           
            if (WName != null)
            {
                list = list.Where(m => m.WName.Contains(WName)).ToList();
            }
        
            if (Ename != null)
            {
                list = list.Where(m => m.Ename.Contains(Ename)).ToList();
            }
           
            //总条数
            var totalCount = list.Count();
            //总页数
            var totalPage = totalCount / pageSize + (totalCount % pageSize > 0 ? 1 : 0);

            list = list.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            PageShowAllot pageShowlist = new PageShowAllot();
            pageShowlist.ShowList = list;
            pageShowlist.ToTalCount = totalCount;
            pageShowlist.PageTotal = totalPage;
            return pageShowlist;
        }
        //报表查询
        [HttpGet]
        public List<ShowAll> ShowFrom()
        {
            var list = _Business.ShowFrom();

            return list;
        }
        //报表查询2
        [HttpGet]
        public List<ShowAll> GetVakues()
        {
            var str = _Business.GetVakues();
            return str;
        }
        //添加盘点
        [HttpPost]
        public int CeeateAllot(Model.AllotModel Allot)
        {
            var str = _Business.CeeateAllot(Allot);
            return str;
        }
        //修改/删除
        [HttpPut]
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