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


        public List<PurchaseModel> ShowAllInfo()
        {

            return _bll.ShowPurchaseInfo();
        
        
        }

    }
}
