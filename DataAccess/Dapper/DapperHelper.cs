﻿using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace DataAccess.Dapper
{
    /// <summary>
    /// Dapper访问数据库类
    /// </summary>
    public static class DapperHelper<T>       
    {
        static string strconn = "Data Source=49.234.34.192;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=sa1234..";

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int CRD(string sql)
        {
            using (SqlConnection conn=new SqlConnection(strconn))
            {
                return conn.Execute(sql);
            }        
        }
        /// <summary>
        /// 显示查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>

        public static List<T> GetAll(string sql)
        {
            using (SqlConnection conn=new SqlConnection(strconn))
            {
                
                return conn.Query<T>(sql).ToList();
            }       
        }
        //获取单条信息Id
        public static int GetId(string sql)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                return Convert.ToInt32(conn.ExecuteScalar(sql));
            }
        }
    }
}
