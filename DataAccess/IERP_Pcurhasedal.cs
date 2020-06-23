using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DataAccess
{
  public  interface IERP_Pcurhasedal
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
        int add(PurchaseModel model);
        /// <summary>
        /// 显示采购列表
        /// </summary>
        /// <returns></returns>
        List<PurchaseModel> ShowPurchaseInfo();
        /// <summary>
        /// 显示结算账户信息
        /// </summary>
        /// <returns></returns>
        List<AccountModel> AccountModels();

    }
}
