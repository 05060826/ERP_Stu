using DataAccess.Dapper;
using Model.CapitalModel;
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
            return DapperHelper<DtoReceiptModel>.CRD(sql);
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
