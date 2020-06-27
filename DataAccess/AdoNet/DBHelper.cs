using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.AdoNet
{
    public class DBHelper
    {
        static string strconn = "Data Source=192.168.1.118;Initial Catalog=ERPDB;Persist Security Info=True;User ID=sa;Pwd=123456";

        static public DataTable GetDataTable(string sql)
        {
            using (SqlConnection conn=new SqlConnection(strconn))
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter apd = new SqlDataAdapter(sql,conn);
                apd.Fill(dt);
                return dt;
            }
        }

        static public DataTable GetDataTableProc(string pname,SqlParameter[] paras=null)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(pname, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                SqlDataAdapter apd = new SqlDataAdapter(cmd);
                apd.Fill(dt);
                return dt;
            }
        }

        static public int ExecuteNonQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                return cmd.ExecuteNonQuery();
            }
        }

        static public int ExecuteNonQueryProc(string pname,SqlParameter[] paras=null)
        {
            using (SqlConnection conn = new SqlConnection(strconn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(pname, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (paras!=null)
                {
                    cmd.Parameters.AddRange(paras);
                }
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
