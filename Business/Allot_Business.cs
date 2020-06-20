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
   public class Business:BaseBusiness
    {
        SqlServerAccess _sqlServerAccess = null;

        //依赖注入
        public Business ()
        {
            if (_sqlServerAccess==null)
            {
                _sqlServerAccess = base.sqlServer;
            }
        }
        //分页显示
        public List<AllotShowModel> ShowPageAllot( string AllotCode, DateTime Sage,string WName,string Eame, int pageindex = 1, int pagesize = 3)
        {
            Dictionary<string, object> parms = new Dictionary<string, object>();
            parms.Add("@AllotCode", AllotCode);
            parms.Add("@Sage", Sage);
            parms.Add("@WName", WName);
            parms.Add("@Eame", Eame);
            parms.Add("@pagesize", pagesize);
            parms.Add("@pageindex", pageindex);
            parms.Add("@TotalCount", "");
           var  data
                = _sqlServerAccess.ExecSqlGetDataTable("proc_Page", parms, "@TotalCount", out string outStr);
            List<AllotShowModel> list = Common.ReflectionHelper.DatatableToList<AllotShowModel>(data.Tables[0]);
            return list;
        }

    }
}
