using DataAccess.AdoNet;
using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Data;

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
        //显示
        public List<AllotModel> ShowPage(string AllotCode, int Sage, string WName, string WName1, int pageIndex, int pagesize)
        {
            Dictionary<string, object> para = new Dictionary<string, object>();
            para.Add("@AllotCode",AllotCode);
            para.Add("@Sage", Sage);
            para.Add("@WName",WName);
            para.Add("@WName1",WName1);
            para.Add("@PageIndex",pageIndex);
            para.Add("@PageSize",pagesize);
            para.Add("@TotalCount",SqlDbType.Int);
            var dt = _sqlServerAccess.ExecSqlGetDataTable("proc_Page",para);
            List<AllotModel> list = Common.ReflectionHelper.DatatableToList<AllotModel>(dt.Tables[0]);

            return list;
        }
    }
}
