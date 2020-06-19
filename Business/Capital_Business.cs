using DataAccess.Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class Capital_Business : IBaseBusiness
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
            return DapperHelper.GetAll<T>(sql);
        }

        public int Update(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
