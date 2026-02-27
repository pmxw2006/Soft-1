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

namespace Soft_Requirements_Specification.lzm
{
    public partial class WeiXiuRiQi : Form
    {
        public string GuZiID = "";
        public WeiXiuRiQi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GuZi = this.textBox1.Text;
            string label3 = this.dateTimePicker1.Text;
            string label5 = this.dateTimePicker3.Text;
            DateTime dateTimePicker1 = DateTime.Parse(label3);
            DateTime dateTimePicker3 = DateTime.Parse(label5);
            string WeiXiuJinE = this.textBox6.Text;
            try
            {

                DialogResult c;
                c = MessageBox.Show("请确认是否添加", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (c == DialogResult.OK)
                {
                    if (GuZi == "" || WeiXiuJinE == "")
                    {
                        MessageBox.Show("基本信息有空");
                    }
                    else
                    {
                        string sql = $"select * from GudinZiChan join WeiXiu on GudinZiChan.GuZiID=WeiXiu.GuZiID where GuZiMing='{GuZi}' and SongXiuRiQi='{dateTimePicker1}';";
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
                            string sql1 = $"update WeiXiu set ShiWanRiQi = '{dateTimePicker3}',WeiXiuJinE='{WeiXiuJinE}' where GuZiID ='{GuZiID}'";
                            DBHelper.ExcNonQuery(sql1);
                            string sql2 = $"update GudinZiChan set ZhuangTaiID = '1' where GuZiID ='{GuZiID}'";
                            DBHelper.ExcNonQuery(sql2);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("基本信息有误");
                        }

                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                if (GuZi == "" || label3 == "" || label5 == "" || WeiXiuJinE == "")
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
