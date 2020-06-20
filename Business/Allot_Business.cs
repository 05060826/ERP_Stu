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
        public int Add<T>(T t)
        {
            throw new NotImplementedException();
        }

        public int Delete(string sql)
        {
            throw new NotImplementedException();
        }

        public List<T> Select<T>(string sql)
        {
            return DapperHelper<T>.GetAll(sql);
        }

        public int Update(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
