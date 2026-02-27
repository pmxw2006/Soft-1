using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Soft_Requirements_Specification
{
    public partial class changjianzhanghu : Form
    {
        public changjianzhanghu()
        {
            InitializeComponent();
        }

        private void cjzh_Click(object sender, EventArgs e)
        {
            string xingming = this.xinming1.Text;
            string mima = this.mima1.Text;
            string mima1=this.mima2.Text;   
            string shengri = this.shengri1.Text;
            string bumen = this.bumen1.Text;
            DateTime shengri1 =DateTime.Parse(shengri);
            try
            {
                DialogResult c;
                c = MessageBox.Show("请确认是否创建账号", "创建账号提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (c == DialogResult.OK)
                {
                    if (xingming == "" || mima == "" || shengri == "" || bumen == "")
                    {
                        MessageBox.Show("基本信息有空");
                    }
                    else if (mima!=mima1)
                    {
                        MessageBox.Show("密码与确认密码不一致请重新输入");
                    }
                    else
                    {
                        //声明变量并储存加密后密码
                        string mimajiami;
                        //使用SHA256算法创建哈希对象，using语句确保加密对象使用后会被正确释放
                        using (SHA256 sha256Hash=SHA256.Create())
                        {
                            //将原始密码字符串转化为UTF8编码的字节数组，哈希算法操作的是字节数组而不是字符串
                            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(mima));
                            //创建一个StringBuilder来高效地构建最终的加密字符串
                            StringBuilder builder = new StringBuilder();
                            //通过for循环得到每个字节单的哈希运算
                            for(int i = 0; i < bytes.Length; i++)
                            {
                                //将每个字节转化为2位十六进制字符串，"x2"格式说明表示将字节格式转化为2位小写十六进制
                                builder.Append(bytes[i].ToString("x2"));
                            }
                            mimajiami = builder.ToString();
                        }
                        string sql = $"select * from YongHu where XingMing ='{xingming}'";
                        DataTable panduan = DBHelper.GetDataTable(sql);
                        if (panduan.Rows.Count > 0)
                        {
                            MessageBox.Show("姓名重复");
                        }
                        else
                        {
                            string sql1 = $"insert YongHu(XingMing,MiMa,ShengRi,BuMen) values('{xingming}','{mimajiami}','{shengri1}','{bumen}')";
                            DataTable panduan1 = DBHelper.GetDataTable(sql1);

                            // 数据库连接字符串，需替换为实际有效的连接字符串
                            string connectionString = "server=.;database=Soft;integrated security=true;";
                            // SQL查询语句，这里从名为YongHu的表中查询所有数据
                            string query = $"select * from YongHu where XingMing = '{xingming}'";

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
                                // 获取第一行中名为"YongHuID"的列的值，并转换为字符串类型
                                string YongHuID = row["YongHuID"].ToString();

                                MessageBox.Show($"创建成功您的账户为{YongHuID}");
                                this.Hide();
                            }
                        }
                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                if (xingming == "" || mima == "" || shengri == "" || bumen == "")
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