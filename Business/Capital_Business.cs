using Common;
using DataAccess.Dapper;
using Model.CapitalModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Capital_Business : IBaseBusiness
    {
        //添加
        public int Add<T>(T t)
        {
            string sql = ReflectionHelper.ModelToInsertSql<T>(t);
            return DapperHelper<T>.CRD(sql);
        }
        //删除
        public int Delete(string sql)
        {
            return DapperHelper<DtoReceiptModel>.CRD(sql);
        }
        //查询
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
