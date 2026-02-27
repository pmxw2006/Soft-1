using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Soft_Requirements_Specification.ckgl
{
    public partial class tjck : Form
    {
        public string LeiXingID="";
        public tjck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ckmc = this.textBox1.Text;
            string cklx = this.comboBox1.Text;
            try
            {
                if (ckmc == "" || cklx == "")
                {
                    MessageBox.Show("仓库名称和仓库类型不能为空");
                }
                else
                {
                    string pdckcf = $"select * from CangKu where CangKuMing ='{ckmc}'";
                    DataTable ckcf = DBHelper.GetDataTable(pdckcf);
                    if (ckcf.Rows.Count > 0)
                    {
                        MessageBox.Show("仓库名称重复");

                    }
                    else
                    {
                        string cklxpd = $"select * from LeiXin where LeiXingI ='{cklx}'";
                        DataTable cklx1 = DBHelper.GetDataTable(cklxpd);
                        if (cklx1.Rows.Count > 0)
                        {
                            string connectionString = "server=.;database=Soft;integrated security=true;";
                            string query = $"select * from LeiXin";
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                                DataSet ds = new DataSet();
                                da.Fill(ds, "LeiXin");
                                DataTable dt = ds.Tables["LeiXin"];
                                DataRow row = dt.Rows[0];
                                LeiXingID = row["LeiXingID"].ToString();
                            }
                            string sql = $"insert CangKu(CangKuMing, LeiXingID) values('{ckmc}', '{LeiXingID}')";
                            bool panduan1 = DBHelper.ExcNonQuery(sql);
                            if (panduan1)
                            {
                                MessageBox.Show("添加仓库成功");
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("添加仓库失败");
                            }
                        }
                        else
                        {
                            MessageBox.Show("仓库类型不存在");
                            DialogResult result = MessageBox.Show("是否跳转至添加仓库类型界面", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                tjcklx tjlx = new tjcklx();
                                tjlx.ShowDialog();
                                string strSql = "select LeiXingID,LeiXingI from LeiXin";
                                DataTable dt = DBHelper.GetDataTable(strSql);
                                if (dt.Rows.Count > 0)
                                {
                                    this.comboBox1.DataSource = dt;
                                    this.comboBox1.ValueMember = "LeiXingID";
                                    this.comboBox1.DisplayMember = "LeiXingI";
                                }
                                else
                                {

                                }
                            }
                            else
                            {

                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                if (ckmc == "" || cklx == "")
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

        private void tjck_Load(object sender, EventArgs e)
        {
            //绑定下拉框数据源
            bindSelectData();
        }
        private void bindSelectData()
        {

            string strSql = "select LeiXingID,LeiXingI from LeiXin";
            DataTable dt = DBHelper.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                this.comboBox1.DataSource = dt;
                this.comboBox1.ValueMember = "LeiXingID";
                this.comboBox1.DisplayMember = "LeiXingI";
            }
            else
            {
             
            }
        }
}}
