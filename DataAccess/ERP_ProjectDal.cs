﻿using System;
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
            using (SqlConnection conn=new SqlConnection("Data Source=192.168.0.157;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
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
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.0.157;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
            {

                return conn.Query<ComityModel>($"select * from Commodity where GId={gid}").ToList();
            }
        }

      
        /// <summary>
        /// 添加采购
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int  add(PurchModel model)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.0.157;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
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
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.0.157;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
            {
                return conn.Query<PurchModel>("select * from Purchase  p join  Supplier su on su.Gid=p.GId").ToList();
            }
        }
        /// <summary>
        /// 显示结算账户下拉框
        /// </summary>
        /// <returns></returns>
        public List<AccountModel> AccountModels()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=192.168.0.157;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
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

            using (SqlConnection conn = new SqlConnection("Data Source=192.168.0.157;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456"))
            {
                return conn.Query<ComityModel>($"select * from Commodity  co join Warehouse ws on co.WId=ws.WId where Sid={sid}").FirstOrDefault();
            }
        }
    }
}
