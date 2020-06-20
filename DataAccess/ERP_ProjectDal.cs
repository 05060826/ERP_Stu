using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccess
{
    public class ERP_ProjectDal : IERP_Pcurhasedal
    {
        /// <summary>
        /// 显示供应商信息
        /// </summary>
        /// <returns></returns>
        public List<SupplierModel> showSupplier()
        {
            
            

            return DapperDBHelper<SupplierModel>.Get();
        }
        /// <summary>
        /// 根据供应商Id显示商品数据
        /// </summary>
        /// <param name="gid"></param>
        /// <returns></returns>

        public List<CommodityModel> showCommodity(int gid)
        {
            return DapperDBHelper<List<CommodityModel>>.GetById(gid).ToList();
        }

        public bool add(PurchaseModel model)
        {
            return DapperDBHelper<PurchaseModel>.Execute(model,SqlChange.Add);
        }

       
    }
}
