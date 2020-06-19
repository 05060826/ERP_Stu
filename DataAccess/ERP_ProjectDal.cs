using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Data.SqlClient;
using DataAccess.Dapper;

namespace DataAccess
{
  public  class ERP_ProjectDal
    {
        /// <summary>
        /// 显示供应商信息
        /// </summary>
        /// <returns></returns>
        public List<SupplierModel> GetAccountModels()
        {

            string strcor = "select * from Supplier ";

            return DapperHelper<SupplierModel>.GetAll(strcor);
        
        }
   
        /// <summary>
        /// 根据供应商Id显示商品数据
        /// </summary>
        /// <param name="gid"></param>
        /// <returns></returns>

        public List<CommodityModel> GetAllCommdityInfo(int gid )
        {

            string strcor = $"select * from Commodity where GId={gid} ";

            return DapperHelper<CommodityModel>.GetAll(strcor);
        
        }

      

    }
}
