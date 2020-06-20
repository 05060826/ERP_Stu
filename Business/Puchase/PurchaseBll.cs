using DataAccess;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Puchase
{
    public class PurchaseBll : IPurchaseInfo
    {
        private IERP_Pcurhasedal _dal;

        public PurchaseBll(IERP_Pcurhasedal eRP_Pcurhasedal)
        {

            _dal = eRP_Pcurhasedal;


        }

        /// <summary>
        /// 添加采购
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int add(PurchaseModel model)
        {
            return _dal.add(model);
        }

        
       /// <summary>
       /// 根据供应商id获取商品
       /// </summary>
       /// <param name="gid"></param>
       /// <returns></returns>
        public List<CommodityModel> showCommodity(int gid)
        {
            return _dal.showCommodity(gid);
        }
        /// <summary>
        /// 显示采购数据
        /// </summary>
        /// <returns></returns>
        public List<PurchaseModel> ShowPurchaseInfo()
        {
            return _dal.ShowPurchaseInfo();
        }

        /// <summary>
        /// 显示供应商
        /// </summary>
        /// <returns></returns>
        public List<SupplierModel> showSupplier()
        {
            return _dal.showSupplier();
        }
    }
}
