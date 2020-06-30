using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    //业务接口
   public interface IBaseBusiness
    {

      

        int Update(string sql);

        int Delete(string sql);

        List<T> Select<T>(string sql);
    }
}
