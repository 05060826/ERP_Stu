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
namespace Business
{
    //仓库调拨表
    public class Allot_Business : IBaseBusiness
    {
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
        public List<T> Select<T>(string sql)
        {
            return DapperHelper<T>.GetAll(sql);
        }
        //修改
        public int Update(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
