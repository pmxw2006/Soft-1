using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Soft_Requirements_Specification
{
    class DBHelper
    {
        public static string connstring = "server=.;database=Soft;integrated security=true;";
        public static SqlConnection emm = null;
        public static void lnitConnection()
        {
            if (emm == null)
            {
                //如果连接对象不存在则连接数据库
                emm = new SqlConnection(connstring);
            }
            if (emm.State == ConnectionState.Closed)
            {
                //如果连接对象关闭则打开连接
                emm.Open();
            }
            else if (emm.State == ConnectionState.Broken)
            {
                //如果连接中断或错误则中断数据库再打开数据库
                emm.Close();
                emm.Open();
            }
        }
        public static DataTable GetDataTable(string strSql)
        {
            DataTable emm1 = new DataTable();
            lnitConnection();
            SqlDataAdapter emm2 = new SqlDataAdapter(strSql, emm);
            emm2.Fill(emm1);
            emm.Close();
            return emm1;
        }

        // 新增方法：支持参数化查询（防止SQL注入）
        public static DataTable GetDataTable(string strSql, Dictionary<string, object> parameters)
        {
            DataTable emm1 = new DataTable();
            lnitConnection();

            using (SqlCommand cmd = new SqlCommand(strSql, emm))
            {
                // 添加参数
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                SqlDataAdapter emm2 = new SqlDataAdapter(cmd);
                emm2.Fill(emm1);
            }

            emm.Close();
            return emm1;
        }

        public static bool ExcNonQuery(string strSql)
        {
            lnitConnection();
            SqlCommand emm3 = new SqlCommand(strSql, emm);
            int emm4 = emm3.ExecuteNonQuery();
            emm.Close();
            return emm4 > 0;
        }
    }
}
