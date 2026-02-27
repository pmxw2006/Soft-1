using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Soft_Requirements_Specification.pjm
{
    public partial class gzghtj : Form
    {
        string GuZiID = "";
        public string GuZiShuLiang = "";
        public gzghtj()
        {
            InitializeComponent();
        }

        private void tj_Click(object sender, EventArgs e)
        {
            string bh = this.textBox1.Text;
            string gs = this.textBox2.Text;
            string sl = this.textBox3.Text;
            string rq = this.dateTimePicker1.Text;
            DateTime rq1 = DateTime.Parse(rq);
            try
            {

                DialogResult c;
                c = MessageBox.Show("请确认是否添加", "创建添加提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (c == DialogResult.OK)
                {
                    if (bh == "" || gs == "" || sl == "" || rq == "")
                    {
                        MessageBox.Show("基本信息有空");
                    }
                    else
                    {
                        // 数据库连接字符串，需替换为实际有效的连接字符串
                        string connectionString = "server=.;database=Soft;integrated security=true;";
                        // SQL查询语句，这里从名为YongHu的表中查询所有数据
                        string query = $"select * from GudinZiChan where GuZiMing = '{bh}'";
                        DataTable panduan1 = DBHelper.GetDataTable(query);
                        if (panduan1.Rows.Count > 0)
                        {
                            // 使用using块确保SqlConnection对象在使用完毕后正确释放资源
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                // 创建SqlDataAdapter对象，用于执行SQL查询并填充DataSet
                                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                                // 创建DataSet对象，用于在内存中存储数据
                                DataSet ds = new DataSet();
                                // 使用SqlDataAdapter的Fill方法将查询结果填充到DataSet中，并指定表名"YongHu"
                                da.Fill(ds, "GudinZiChan");
                                // 获取DataSet中名为"YongHu"的DataTable
                                DataTable dt = ds.Tables["GudinZiChan"];
                                // 获取DataTable的第一行（索引从0开始）
                                DataRow row = dt.Rows[0];
                                // 获取第一行中名为"YongHuID"的列的值，并转换为字符串类型
                                GuZiID = row["GuZiID"].ToString();
                            }
                            string sql = $"select * from Jei where GuZiID ='{GuZiID}' and ZuJieGongSi='{gs}'";
                            DataTable panduan = DBHelper.GetDataTable(sql);
                            if (panduan.Rows.Count > 0)
                            {
                                string sql1 = $"insert Huan(GuZiID,GuiHuanGongSi,GuiHuanShuLiang,HuanRiQi) values('{GuZiID}','{gs}','{sl}','{rq1}')";
                                string sql2 = $"update GudinZiChan set ZhuangTaiID = '1' where GuZiID ='{GuZiID}'";
                                DBHelper.ExcNonQuery(sql2);
                                DBHelper.ExcNonQuery(sql1);
                                MessageBox.Show($"添加成功");
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("公司名错误");
                            }
                        }
                        else {
                            c=MessageBox.Show("该商品未借出", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (c == DialogResult.OK)
                            {
                                gzjhtj a = new gzjhtj();
                                a.ShowDialog();
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
                if (bh == "" || gs == "" || sl == "" || rq == "")
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
