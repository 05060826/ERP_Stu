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
using Newtonsoft.Json;
using System.Data.SqlClient;
namespace Business
{
    //仓库调拨表
    public class Allot_Business
    {


        //添加
        public int CeeateAllot(Model.AllotModel Allot)
        {
            SqlParameter[] para = new SqlParameter[]
            {
             new SqlParameter("@AllotCode",Allot.AllotCode),
              new SqlParameter("@Sid",Allot.Sid),
               new SqlParameter("@Number",Allot.Number),
                new SqlParameter("@Units",Allot.Units),
                 new SqlParameter("@Wid",Allot.Wid),
                  new SqlParameter("@Eid",Allot.Eid),
                   new SqlParameter("@ATime",Allot.ATime),
                    new SqlParameter("@Remark",Allot.Remark),
                  new SqlParameter("@IsState",1),
                   new SqlParameter("@msg",SqlDbType.Int),
            };
            para[9].Direction = ParameterDirection.Output;
            DBHelper.ExecuteNonQueryProc("P_add", para);
            return Convert.ToInt32(para[9].Value);
        }        
        //显示 查询 调拨表
        public List<AllotShowModel> ShowPageAllot()
        {
            var sql = "select *from Allot join Commodity on Allot.Sid=Commodity.Sid join Warehouse on Allot.Wid=Warehouse.WId join ExportStoreroom on Allot.Eid=ExportStoreroom.EId where 1=1";
            return DapperHelper<AllotShowModel>.GetAll(sql);
        }
        //报表
        public List<ShowAll> ShowFrom()
        {
            var sql = "select * from Checks  join Warehouse  on Checks.Cid=Warehouse.WId  join Commodity  on Checks.Sid = Commodity.Sid";
          
            return DapperHelper<ShowAll>.GetAll(sql);
        }

        public List<ShowAll> GetVakues()
        {
            var linq = from cs in ShowFrom()
                       group cs by cs.Cid into s
                       select new ShowAll
                       {
                           SystemNumber = s.Count(),
                           CheckNumber = s.Key
                       };
            return linq.OrderBy(m => m.CheckNumber).ToList();
        }
        //修改
        public int UpdateAll(int Id)
        {
            var str = $"update Allot  set IsState=0 where AllotId={Id}";
            return DapperHelper<AllotModel>.CRD(str);
        }
        //盘点表数据
        public List<ShowModel> CheckShowModel(string WName, string Sname)
        {
            var sql = "select c.Cid,c.Sid,c.SName,c.Specification,c.SystemNumber,c.CheckNumber,c.Units,cd.SName,w.Wname from Checks c join Warehouse w on c.Cid=w.WId join Commodity cd on c.Sid=cd.Sid  where 1 = 1 ";
            if (!string.IsNullOrWhiteSpace(WName))
            {
                sql += $"and w.WName like '%{WName}%'";
            }
            if (!string.IsNullOrWhiteSpace(Sname))
            {
                sql += $"and  cd.SName like '%{Sname}%'";
            }

            return DapperHelper<ShowModel>.GetAll(sql);
        }
        //下拉商品
        public List<CommodityModel> ShowComm()
        {
            List<CommodityModel> list = DapperHelper<CommodityModel>.GetAll("select * from Commodity");
            return list;
        }
        //下拉入库
        public List<WarehouseModel> ShowWare()
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






 