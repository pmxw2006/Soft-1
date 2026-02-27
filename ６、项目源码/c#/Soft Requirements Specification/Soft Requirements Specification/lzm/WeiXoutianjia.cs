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

namespace Soft_Requirements_Specification.lzm
{
    public partial class WeiXoutianjia : Form
    {
        public string GuZiID = "";
        public WeiXoutianjia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GuZi = this.textBox1.Text;
            string WeiXiuShuLiang = this.textBox2.Text;
            string label3 = this.dateTimePicker1.Text;
            string label4 = this.dateTimePicker2.Text;
            DateTime dateTimePicker1 = DateTime.Parse(label3);
            DateTime dateTimePicker2 = DateTime.Parse(label4);
            try
            {

                DialogResult c;
                c = MessageBox.Show("请确认是否添加", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (c == DialogResult.OK)
                {
                    if (GuZi == "" || WeiXiuShuLiang == "")
                    {
                        MessageBox.Show("基本信息有空");
                    }
                    else
                    {
                        string sql = $"select * from GudinZiChan where GuZiMing='{GuZi}';";
                        DataTable panduan = DBHelper.GetDataTable(sql);
                        if (panduan.Rows.Count > 0)
                        {
                            string connectionString = "server=.;database=Soft;integrated security=true;";
                            string query = $"select * from GudinZiChan where GuZiMing='{GuZi}'";
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                                DataSet ds = new DataSet();
                                da.Fill(ds, "GudinZiChan");
                                DataTable dt = ds.Tables["GudinZiChan"];
                                DataRow row = dt.Rows[0];
                                GuZiID = row["GuZiID"].ToString();
                            }
                            string sql1 = $"insert WeiXiu(GuZiID,WeiXiuShuLiang,SongXiuRiQi,YuWanRiQi) values('{GuZiID}','{WeiXiuShuLiang}','{dateTimePicker1}','{dateTimePicker2}')";
                            string sql2 = $"update GudinZiChan set ZhuangTaiID = '2' where GuZiID ='{GuZiID}'";
                            DBHelper.GetDataTable(sql2);
                            DBHelper.GetDataTable(sql1);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("该商品不存在");
                        }

                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                if (GuZi == "" || WeiXiuShuLiang == "" || label3 == "" || label4 == "")
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
