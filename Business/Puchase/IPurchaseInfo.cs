using System;
using System.Collections.Generic;
using System.Text;
using Model;
using DataAccess;

namespace Business.Puchase
{
   public interface IPurchaseInfo
    {
        /// <summary>
        /// 显示供应商
        /// </summary>
        /// <returns></returns>
        List<SupplierModel> showSupplier();

        /// <summary>
        /// 显示商品
        /// </summary>
        /// <param name="gid">供应商Id</param>
        /// <returns></returns>
        List<CommodityModel> showCommodity(int gid);

        /// <summary>
        /// 添加采购表单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool add(PurchaseModel model);


    }
}
