using DataAccess.AdoNet;
using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Data;
using Dapper;
using Model.Model;
using System.Data.SqlClient;
using DataAccess.Dapper;
using Model.AarehouseModel;
using System.Linq;

namespace Business
{
    //仓库调拨表
    public class Allot_Business 
    {
        
        //添加
        public int Add<AllotModel>(Model.AllotModel Allot)
        {
           var  sql =$"insert into Allot values '{Allot.AllotCode}','{Allot.Sid}','{Allot.Number}','{Allot.Units}','{Allot.Units}','{Allot.Wid}','{Allot.Eid}','{Allot.ATime}','{Allot.Remark}','{Allot.IsState}'";
            return DapperHelper<AllotModel>.CRD(sql);
        }
        //显示 查询 调拨表
        public List<AllotShowModel> ShowPageAllot(string AllotCode = null, string WName = null, string Ename = null)
        {
            var sql = "select *from Allot join Commodity on Allot.Sid=Commodity.Sid join Warehouse on Allot.Wid=Warehouse.WId join ExportStoreroom on Allot.Eid=ExportStoreroom.EId where 1=1";
            if (!string.IsNullOrWhiteSpace(AllotCode))
            {
                sql += $"and Allot.AllotCode like '%{AllotCode}%'";
            }
            if (!string.IsNullOrWhiteSpace(WName))
            {
                sql += $"and Warehouse.WName like'%{WName}%'";
            }
            if (!string.IsNullOrWhiteSpace(Ename))
            {
                sql += $"and ExportStoreroom.Ename like'%{Ename}%'";
            }
            return DapperHelper<AllotShowModel>.GetAll(sql);
        }
        //修改
        public int Update(int  Id)
        {
            var str = $"update Allot  set IsState=0 where AllotId={Id}";
            return DapperHelper<AllotModel>.CRD(str);
        }

        
        //盘点表数据
        public List<CheckShowModel> CheckShowModel(string WName, string Sname)
        {
            string strconn = "Data Source=192.168.1.114;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456";
            using (SqlConnection conn=new SqlConnection(strconn))
            {
                var sql = "select *from Checks join Warehouse on Checks.Cid=Warehouse.WId join Commodity on Checks.Sid=Commodity.Sid  where 1 = 1 ";
                if (!string.IsNullOrWhiteSpace(WName))
                {
                    sql += $"and Warehouse.WName like '%{WName}%''";
                }
                if (!string.IsNullOrWhiteSpace(Sname))
                {
                    sql += $"and  Commodity.SName like '%{Sname}%''";
                }
                return conn.Query<CheckShowModel>(sql).ToList();
            }
            
           
           
        }
        //下拉商品
       public List<CommodityModel>ShowComm()
        {
            List<CommodityModel> list = DapperHelper<CommodityModel>.GetAll("select * from Commodity");
            return list;
        }
        //下拉入库
        public List<WarehouseModel>ShowWare()
        {
            List<WarehouseModel> list = DapperHelper<WarehouseModel>.GetAll("select * from Warehouse");
            return list;
        }
        //下拉出库
        public List<ExportStoreroomModel> ShowExportSto()
        {
            List<ExportStoreroomModel> list = DapperHelper<ExportStoreroomModel>.GetAll("select * from ExportStoreroom");
            return list;
        }
    }
}
