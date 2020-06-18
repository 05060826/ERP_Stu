using DataAccess.AdoNet;
using System;
using System.Collections.Generic;
using System.Text;
using Model;
namespace Business
{
    //仓库调拨表
   public class Allot_Business:BaseBusiness
    {
        SqlServerAccess _sqlServerAccess = null;
        //依赖注入
        public Allot_Business ()
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
            return null;
        }
    }
}
