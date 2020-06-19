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
       public List<AllotShowModel>ListShow()
        {
            var list = new List<AllotShowModel>();
            list = DapperHelper<AllotShowModel>.GetAll("select * from  Allot join Commodity  on Allot.Sid=Commodity.Sid join Warehouse  on Allot.Wid=Warehouse.WId");
            return list;
        }
        string constr = "Data Source=192.168.1.113;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa";
         /// 采用存储过程分页
         /// </summary>
         /// <param name="page"></param>
         /// <param name="pageSize"></param>
         /// <returns></returns>
        public AllotShowModel GetPageByProcList(int page = 1, int pageSize = 10)
         {
             AllotShowModel model = new AllotShowModel();
             var list = new List<AllotShowModel>();
             //string sql = @"select Id,UserName,Nation,TrueName,Birthday,LocalAddressGender from UserInfo";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                DynamicParameters parm = new DynamicParameters();
                parm.Add("viewName", "AllotShowModel");
                parm.Add("fieldName", "*");
                parm.Add("keyName", "AllotId");
                parm.Add("pageSize", pageSize);
                parm.Add("@pageIndex", page);
                parm.Add("orderString", "AllotId");
                parm.Add("recordTotal", 0, DbType.Int32, ParameterDirection.Output);
                //参数名得和存储过程的变量名相同（参数可以跳跃传，键值对方式即可）
                //强类型
                //list = conn.Query<UserInfo>("P_GridViewPager", new { viewName = "Edu_StudentSelectedCourse", fieldName = "*", keyName = "Id", pageSize = 20, pageNo = 1, orderString = "id" }, commandType: CommandType.StoredProcedure).ToList();
                 //标准写法
                 //list = conn.Query<UserInfo>(sql,commandType: CommandType.Text).AsList();
                 //dapper扩展写法
                 //list = conn.GetList<UserInfo>().AsList();
                 list = conn.Query<AllotShowModel>("ProcViewPager", parm, commandType:CommandType.StoredProcedure).AsList();
                 int totalCount = parm.Get<int>("@recordTotal");//返回总页数
                 model.user = list.ToString();
                 model.TotalCount = totalCount;
                 conn.Close();
             }
             return model;
         }
    }
}
