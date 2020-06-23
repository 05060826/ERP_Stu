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

namespace Business
{
    //仓库调拨表
    public class Allot_Business 
    {
        BaseBusiness _baseBusiness = null;
        public Allot_Business()
        {
            _baseBusiness = new BaseBusiness();
        }
        //添加
        public int Add<T>(T t)
        {
            throw new NotImplementedException();
        }
        //删除
        public int Delete(string sql)
        {
            throw new NotImplementedException();
        }
        //显示 查询 调拨表
        public List<AllotShowModel> ShowPageAllot(string AllotCode = null, string WName = null, string Ename = null)
        {
            var sql = "select *from Allot join Commodity on Allot.Sid=Commodity.Sid join Warehouse on Allot.Wid=Warehouse.WId join ExportStoreroom on Allot.Eid=ExportStoreroom.EId where 1=1";
            if (!string.IsNullOrEmpty(AllotCode))
            {
                sql += $"and Allot.AllotCode like '%{AllotCode}%'";
            }
            if (!string.IsNullOrEmpty(WName))
            {
                sql += $"and Warehouse.WName like'{WName}'";
            }
            if (!string.IsNullOrEmpty(Ename))
            {
                sql += $"and ExportStoreroom.Ename like'{Ename}'";
            }
            return _baseBusiness.Select<AllotShowModel>(sql);
        }
        //修改
        public int Update(string sql)
        {
            throw new NotImplementedException();
        }
        //盘点表数据
        public List<CheckShowModel> CheckShowModel(string WName, string Sname)
        {
            var sql = "select *from Checks join Warehouse on Checks.Cid=Warehouse.WId join Commodity on Checks.Sid=Commodity.Sid  where 1 = 1 ";
            if (!string.IsNullOrEmpty(WName))
            {
                sql += $"and Warehouse.WName like '%{WName}%'";
            }
            if (!string.IsNullOrEmpty(Sname))
            {
                sql += $"and  Commodity.SName like '%{Sname}%''";
            }
            return _baseBusiness.Select<CheckShowModel>(sql);
            
        }
    }
}
