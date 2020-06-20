
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public static class DapperDBHelper<T> 
    {
        
        private static string conStr = "Data Source=192.168.1.117;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;";
        private static string addStr = "";
        private static string deleteStr = "";
        private static string editStr = "";
        private static string getStr = "";
        private static string getStrById = "";
        private static Type type;
        private static string propStr = "";
        private static string paraStr = "";
        private static string keyStr = "";
        private static string propParaStr = "";
        //静态构造函数，反射动态获取sql
        static DapperDBHelper()
        {
            type = typeof(T);
            propStr = string.Join(",", type.GetProperties().Where(m => !m.IsDefined(typeof(IdentityQueQueAttribute), true)).Select(m => m.Name).ToList());
            paraStr = string.Join(",", type.GetProperties().Where(m => !m.IsDefined(typeof(IdentityQueQueAttribute), true)).Select(m => $"@{ m.Name}").ToList());
            keyStr = type.GetProperties().Where(m => m.IsDefined(typeof(KeyQueQueAttribute), true)).Select(m => m.Name).FirstOrDefault().ToString();
            propParaStr = string.Join(",", type.GetProperties().Where(m => !m.IsDefined(typeof(IdentityQueQueAttribute), true)).Select(m => $"{m.Name}=@{ m.Name}").ToList());

            addStr =$"insert into {type.Name} ({propStr}) values ({paraStr})";
            deleteStr = $"delete from {type.Name} where {keyStr} =@{keyStr} ";
            editStr = $"update {type.Name} set {propParaStr} where {keyStr}=@{keyStr}";
            getStr = $"select * from {type.Name}";
            getStrById = $"select * from {type.Name}  where {keyStr}=@{keyStr}";
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="t"></param>
        /// <param name="sqlChange"></param>
        /// <returns></returns>
        public static bool Execute(T t, SqlChange sqlChange)
        {
            using (IDbConnection db =new  SqlConnection(conStr))
            {
                string sql = "";
                switch (sqlChange)
                {
                    case SqlChange.Add:
                        sql = addStr;
                        break;
                    case SqlChange.Delete:
                        sql =deleteStr;
                        break;
                    case SqlChange.Update:
                        sql = editStr;
                        break;
                    default:
                        break;
                }
                return db.Execute(sql, t) > 0;
            }
        }
        /// <summary>
        /// 存储过程增删改
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool Execute_Proc(string procName,object obj)
        {
            using (IDbConnection db = new SqlConnection(conStr))
            {
                return db.Execute(procName, obj,commandType:CommandType.StoredProcedure) > 0;
            }
        }
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <returns></returns>
        public static List<T> Get()
        {
            using (IDbConnection db = new SqlConnection(conStr))
            {
                return db.Query<T>(getStr).ToList();
            }  
        }

        /// <summary>
        /// 存储过程获取集合
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static List<T> Get_Proc(string procName, object obj=null)
        {
            using (IDbConnection db = new SqlConnection(conStr))
            {
                if (obj!=null)
                {
                    return db.Query<T>(procName,obj,commandType:CommandType.StoredProcedure).ToList();
                }
                return db.Query<T>(procName, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static T GetById(object id)
        {
            using (IDbConnection db = new SqlConnection(conStr))
            {
                return db.QueryFirst<T>(getStrById,id);
            }
        }
    }
    public enum SqlChange
    {
        Add=0,
        Delete=1,
        Update=3,
        Get=4,
        GetById
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class IdentityQueQueAttribute : Attribute
    { 
        
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class KeyQueQueAttribute : Attribute
    {

    }
}
