using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccess;
using Model;
using Business.Puchase;
using ERPAPI.DatasModel;
namespace ERPAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {

        private IPurchaseInfo _bll;

        public PurchaseController(IPurchaseInfo purchaseInfo)
        {


            _bll = purchaseInfo;

        }
        [HttpPost]
        /// <summary>
        /// 添加采购
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int add(PurchaseModel model)
        {
            return _bll.add(model);
        }

        [HttpGet]
        /// <summary>
        /// 根据供应商id获取商品
        /// </summary>
        /// <param name="gid"></param>
        /// <returns></returns>
        public List<CommodityModel> showCommodity(int gid)
        {
            return _bll.showCommodity(gid);
        }
        [HttpGet]
        /// <summary>
        /// 显示供应商
        /// </summary>
        /// <returns></returns>
        public List<SupplierModel> showSupplier()
        {
            return _bll.showSupplier();
        }

        [HttpGet]


        public List<PurchaseInfos> ShowAllInfo(string  gname,DateTime time,int state)
        {

           var list= _bll.ShowPurchaseInfo();

          
            List<PurchaseInfos> showlist = (from p in list
                                            select new
                                              PurchaseInfos
                                            {
                                                ReceIptsId = p.ReceIptsId,
                                                ReceIptsCode = p.ReceIptsCode,
                                                Gname=p.Gname,
                                                Discount=p.Discount,
                                                CMoney=p.CMoney,
                                                Datetime=p.Datetime,
                                                PayMent=p.PayMent,
                                            }).ToList();


            if (string.IsNullOrEmpty(gname))
            {
                showlist = showlist.Where(m => m.Gname.Contains(gname)).ToList();
            }
            if (time!=null)
            {
                showlist = showlist.Where(m => m.Datetime == time).ToList();
            }
            //if ()
            //{
            //    showlist=
            //}

            return showlist;
        
        
        }

    }
}
