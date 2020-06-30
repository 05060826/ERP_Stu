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
        /// <summary>
        /// 显示供应商信息
        /// </summary>
        /// <returns></returns>
        public List<SupplierModel> showSupplier()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.1.118;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
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
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.1.118;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
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
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.1.118;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
            {

                return conn.Execute($"insert into Purchase values ('{model.ReceIptsCode}',{model.SId},{model.GId},{model.Number},{model.Rate},{model.Discount},{model.CMoney},{model.AId},'{model.Datetime}',{model.PayMent},'{model.Remark}',{model.IsState})");
            }
        }
        /// <summary>
        /// 显示所有采购数据
        /// </summary>
        /// <returns></returns>
        public List<PurchModel> ShowPurchaseInfo()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.1.118;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
            {
                return conn.Query<PurchModel>("select * from Purchase  p join  Supplier su on su.Gid=p.GId where p.IsState=1").ToList();
            }


        }
        /// <summary>
        /// 显示结算账户下拉框
        /// </summary>
        /// <returns></returns>
        public List<AccountModel> AccountModels()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.1.118;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
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

            using (SqlConnection conn = new SqlConnection("Data Source=192.168.1.118;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
            {
                return conn.Query<ComityModel>($"select * from Commodity  co join Warehouse ws on co.WId=ws.WId where Sid={sid}").FirstOrDefault();
            }
        }
        /// <summary>
        /// 修改数据在页面是否显示页面删除
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public int UpdateIstate(int rid)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=192.168.1.118;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
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
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.1.118;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
            {
                return conn.Query<PurchModel>($"select * from Purchase  p join  Supplier su on su.Gid=p.GId join  Commodity co on p.SId=co.Sid join  Warehouse wa on co.WId=wa.WId where ReceIptsId={rid}").FirstOrDefault();
            }

        }
        /// <summary>
        /// 根据单据编号反填
        /// </summary>
        /// <param name="nameCode"></param>
        /// <returns></returns>
       public PurchModel DropFanTian(string nameCode)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=192.168.1.118;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
            {
                return conn.Query<PurchModel>($"select * from Purchase  p join  Supplier su on su.Gid=p.GId join  Commodity co on p.SId=co.Sid join  Warehouse wa on co.WId=wa.WId where ReceIptsCode='{nameCode}'").FirstOrDefault();
            }


        }


        /// <summary>
        /// 修改支付状态
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public int UpdatePaMent(int rid)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=192.168.1.118;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
            {
                return conn.Execute($"update Purchase set PayMent=3 where ReceIptsId={rid}");
            }


        }
        /// <summary>
        /// 修改支付状态未支付
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public int UpdatePaMents(int rid)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=192.168.1.118;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
            {
                return conn.Execute($"update Purchase set PayMent=4 where ReceIptsId={rid}");
            }

        }




    }
}
