using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Requirements_Specification.hu.gerenzhongxin
{
    public partial class xiugaigerenxinxi : Form
    {
        public string CurrentUserZhangHao { get; private set; }

        // 修改构造函数接收参数
        public xiugaigerenxinxi(string CuserZhangHao)
        {
            InitializeComponent();
            this.CurrentUserZhangHao = CuserZhangHao;
        }
        private void xiugaigerenxinxi_Load(object sender, EventArgs e)
        {
            string zh = this.CurrentUserZhangHao;
            // 数据库连接字符串，需替换为实际有效的连接字符串
            string connectionString = "server=.;database=Soft;integrated security=true;";
            // SQL查询语句，这里从名为YongHu的表中查询所有数据
            string query = $"select * from YongHu where YongHuID ='{zh}'";

            // 使用using块确保SqlConnection对象在使用完毕后正确释放资源
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // 创建SqlDataAdapter对象，用于执行SQL查询并填充DataSet
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                // 创建DataSet对象，用于在内存中存储数据
                DataSet ds = new DataSet();
                // 使用SqlDataAdapter的Fill方法将查询结果填充到DataSet中，并指定表名"YongHu"
                da.Fill(ds, "YongHu");

                // 获取DataSet中名为"YongHu"的DataTable
                DataTable dt = ds.Tables["YongHu"];
                // 获取DataTable的第一行（索引从0开始）
                DataRow row = dt.Rows[0];
                // 获取第一行中名为"XingMing"的列的值，并转换为字符串类型
                this.xinming1.Text = row["XingMing"].ToString();
                this.shengri1.Text = row["ShengRi"].ToString();
                this.bumen1.Text = row["BuMen"].ToString();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string xingming = this.xinming1.Text;
            string shengri = this.shengri1.Text;
            DateTime shengri1 = DateTime.Parse(shengri);
            try
            {

                DialogResult c;
                c = MessageBox.Show("请确认是否修改个人信息", "修改个人信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (c == DialogResult.OK)
                {
                    if (xingming == "" || shengri == "")
                    {
                        MessageBox.Show("基本信息有空");
                    }
                    else
                    {
                        string sql1 = $"update YongHu set XingMing = '{xingming}',ShengRi='{shengri1}' where YongHuID ='{CurrentUserZhangHao}'";
                        DBHelper.ExcNonQuery(sql1);
                        MessageBox.Show("修改成功");
                        string zh = this.CurrentUserZhangHao;
                        // 数据库连接字符串，需替换为实际有效的连接字符串
                        string connectionString = "server=.;database=Soft;integrated security=true;";
                        // SQL查询语句，这里从名为YongHu的表中查询所有数据
                        string query = $"select * from YongHu where YongHuID ='{zh}'";

                        // 使用using块确保SqlConnection对象在使用完毕后正确释放资源
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            // 创建SqlDataAdapter对象，用于执行SQL查询并填充DataSet
                            SqlDataAdapter da = new SqlDataAdapter(query, conn);
                            // 创建DataSet对象，用于在内存中存储数据
                            DataSet ds = new DataSet();
                            // 使用SqlDataAdapter的Fill方法将查询结果填充到DataSet中，并指定表名"YongHu"
                            da.Fill(ds, "YongHu");

                            // 获取DataSet中名为"YongHu"的DataTable
                            DataTable dt = ds.Tables["YongHu"];
                            // 获取DataTable的第一行（索引从0开始）
                            DataRow row = dt.Rows[0];
                            // 获取第一行中名为"XingMing"的列的值，并转换为字符串类型
                            this.xinming1.Text = row["XingMing"].ToString();
                            this.shengri1.Text = row["ShengRi"].ToString();
                            this.bumen1.Text = row["BuMen"].ToString();
                        }
                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                if (xingming == "" || shengri == "")
                {
                    MessageBox.Show("基本信息有空");
                }
                else
                {
                    MessageBox.Show("基本信息错误请重新输入");
                }
            }
            finally
            {

            }
        }
    }
}
