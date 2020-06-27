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
        //添加
        [HttpPost]
        public int Add(Model.AllotModel Allot)
        {
            var str = _Business.Add(Allot);
            return str;
        }
        //修改/删除
        [HttpPost]
        public int Update(int Id)
        {
            return _Business.Update(Id);
        }

        [HttpGet]
        //盘点表数据
        public List<ShowModel> CheckShowModel(string WName,string Ename)
        {
            var list = _Business.CheckShowModel(WName,Ename);
            return list;
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