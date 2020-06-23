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

        /// <summary>
        /// 结算账户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<AccountModel> AccountModels()
        {

            return _bll.AccountModels();
        }
        [HttpGet]

        /// <summary>
        /// 根据商品id查询商品信息
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public CommodityModel ShowCommdityInfo(int sid)
        {
            return _bll.ShowCommdityInfo(sid);
        }


        [HttpGet]
        //显示采购列表
        public PageShow ShowAllInfo(string  gname=null,DateTime? time=null,int state=1,int pageIndex=1,int pageSize=3)
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


            //供货商名称查询
            if (gname!=null)
            {
                showlist = showlist.Where(m => m.Gname.Contains(gname)).ToList();
            }
            //时间查询
            if (time!=null)
            {
                showlist = showlist.Where(m => m.Datetime == time).ToList();
            }
            //状态查询
            if (state==0)
            {
                showlist = showlist.Where(m => m.PayMent.Equals(state)).ToList();
            }
            if (state==1)
            {
                showlist = showlist.Where(m => m.PayMent.Equals(state)).ToList();
            }
            //总条数
            var totalCount = showlist.Count();
            //总页数
          var totalPage = totalCount / pageSize + (totalCount % pageSize > 0 ? 1 : 0);

            showlist = showlist.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            PageShow pageShowlist = new PageShow();


            pageShowlist.ShowList = showlist;
            pageShowlist.ToTalCount = totalCount;
            pageShowlist.PageTotal = totalPage;
    

           
            
            return pageShowlist;
        
        
        }


        [HttpGet]
        public List<PurchaseModel> ShowInfo()
        {

            return _bll.ShowPurchaseInfo();
        }

    }
}
