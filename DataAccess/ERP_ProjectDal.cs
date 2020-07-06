using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Model.PuchasesInfoModel;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace DataAccess
{
    public class ERP_ProjectDal : IERP_Pcurhasedal
    {

        //连接字符串

        string strconn = "Data Source=49.234.34.192;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=sa1234..";


        /// <summary>
        /// 显示供应商信息
        /// </summary>
        /// <returns></returns>
        public List<SupplierModel> showSupplier()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {

                return conn.Query<SupplierModel>("select * from Supplier").ToList();
            }

        }
        /// <summary>
        /// 根据供应商Id显示商品数据
        /// </summary>
        /// <param name="gid"></param>
        /// <returns></returns>

        public List<ComityModel> showCommodity(int gid)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {

                return conn.Query<ComityModel>($"select * from Commodity where GId={gid}").ToList();
            }
        }


        /// <summary>
        /// 添加采购
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int add(PurchModel model)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {

                return conn.Execute($"insert into Purchase values ('{model.ReceIptsCode}',{model.SId},{model.GId},{model.Number},{model.Rate},{model.Discount},{model.CMoney},{model.AId},'{model.Datetime}',{model.PayMent},'{model.Remark}',{model.IsState},{model.WId})");
            }
        }



        /// <summary>
        /// 仓库显示数据
        /// </summary>
        /// <returns></returns>

        public List<WarehouseModel> CangKu()
        {


            using (SqlConnection conn = new SqlConnection(strconn))
            {

                return conn.Query<WarehouseModel>("select * from Warehouse").ToList();
            }


        }
        /// <summary>
        /// 显示所有采购数据
        /// </summary>
        /// <returns></returns>
        public List<PurchModel> ShowPurchaseInfo()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                return conn.Query<PurchModel>("select * from Purchase  p join  Supplier su on su.Gid=p.GId where p.IsState=1 and  (p.PayMent=0 or  p.PayMent=1 )").ToList();
            }
        }
        /// <summary>
        /// 显示结算账户下拉框
        /// </summary>
        /// <returns></returns>
        public List<AccountModel> AccountModels()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {

                return conn.Query<AccountModel>($"select * from Account").ToList();
            }
        }

        /// <summary>
        /// 查询商品信息根据商品信息表Id
        /// </summary>
        /// <param name="sid"></param>
        /// <returns></returns>
        public ComityModel ShowCommdityInfo(int sid)
        {

            using (SqlConnection conn = new SqlConnection(strconn))
            {
                return conn.Query<ComityModel>($"select * from Commodity  where Sid={sid}").FirstOrDefault();
            }
        }
        /// <summary>
        /// 修改数据在页面是否显示页面删除
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public int UpdateIstate(int rid)
        {

            using (SqlConnection conn = new SqlConnection(strconn))
            {
                return conn.Execute($"update Purchase set IsState=0 where ReceIptsId={rid}");
            }
        }

        /// <summary>
        /// 根据采购单据Id进行反填
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public PurchModel FanTian(int rid)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                return conn.Query<PurchModel>($"select * from Purchase  p join  Supplier su on su.Gid=p.GId join  Commodity co on p.SId=co.Sid join  Warehouse wa on p.WId=wa.WId where ReceIptsId={rid}").FirstOrDefault();
            }

        }



      /// <summary>
      /// 修改支付状态为已付款
      /// </summary>
      /// <param name="rid"></param>
      /// <param name="cgthCode"></param>
      /// <returns></returns>
        public int UpdatePaMent(int rid, string cgthCode)
        {

            using (SqlConnection conn = new SqlConnection(strconn))
            {
                return conn.Execute($"update Purchase set PayMent=3 ,ReceIptsCode='{cgthCode}'  where ReceIptsId={rid}");
            }


        }


    /// <summary>
    /// 修改支付状态为未付款
    /// </summary>
    /// <param name="rid"></param>
    /// <param name="cgthCode"></param>
    /// <returns></returns>
        public int UpdatePaMents(int rid, string cgthCode)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                return conn.Execute($"update Purchase set PayMent=4 ,ReceIptsCode='{cgthCode}'  where ReceIptsId={rid}");
            }
        }

        //public PurchModel DropFanTian(string nameCode)
        //{
        //    throw new NotImplementedException();
        //}


        /// <summary>
        /// 显示退货列表
        /// </summary>
        /// <returns></returns>
        public List<PurchModel> ShowPurchasTh()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                return conn.Query<PurchModel>("select * from Purchase  p join  Supplier su on su.Gid=p.GId where p.IsState=1 and  (p.PayMent=3 or  p.PayMent=4 )").ToList();
            }
        }




        /// <summary>
        /// 显示采购报表列表
        /// </summary>
        /// <returns></returns>
        public List<PurchModel> BaoPurchaseInfo()
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                return conn.Query<PurchModel>("select SName,SUM(p.Number) Number  from Commodity co left  join Purchase   p on co.Sid=p.SId left join  Supplier su on su.Gid=p.GId where  p.PayMent=1 or p.PayMent=0 group by  SName ").ToList();

            }


        }
    }
}
