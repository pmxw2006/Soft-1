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
    public partial class GudinZiChanyianjia : Form
    {
        public GudinZiChanyianjia()
        {
            InitializeComponent();
        }

        private void cjzh_Click(object sender, System.EventArgs e)
        {
            string GuZiMing = this.textBox1.Text;
            string CangKuID = this.comboBox1.Text;
            string GuZiShuLiang = this.textBox3.Text;
            string GuZiJiaZhi = this.textBox4.Text;
            string label5 = this.shengri1.Text;
            DateTime shengri1 = DateTime.Parse(label5);
            try
            {

                DialogResult c;
                c = MessageBox.Show("请确认是否添加", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (c == DialogResult.OK)
                {
                    if (GuZiMing == "" || CangKuID == "" || GuZiShuLiang == "" || GuZiJiaZhi == "")
                    {
                        MessageBox.Show("基本信息有空");
                    }
                    else
                    {
                        string sql = $"select * from YongHu where XingMing ='{GuZiMing}'";
                        DataTable panduan = DBHelper.GetDataTable(sql);
                        if (panduan.Rows.Count > 0)
                        {
                            MessageBox.Show("固定资产重复");
                        }
                        else
                        {
                            string cklxpd = $"select * from CangKu where CangKuID ='{CangKuID}'";
                            DataTable cklx1 = DBHelper.GetDataTable(cklxpd);
                            if (cklx1.Rows.Count > 0)
                            {
                                string sql1 = $"insert GudinZiChan(GuZiMing,CangKuID,GuZiShuLiang,GuZiJiaZhi,ChuChangRiQi,ZhuangTaiID) values('{GuZiMing}','{CangKuID}','{GuZiShuLiang}','{GuZiJiaZhi}','{shengri1}','1')";
                                bool panduan1 = DBHelper.ExcNonQuery(sql1);
                                if (panduan1)
                                {
                                    MessageBox.Show("添加成功");
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("添加失败");
                                }
                            }
                            else
                            {
                                MessageBox.Show("仓库类型不存在");
                                string strSql = "select CangKuID,CangKuMing from CangKu";
                                DataTable dt = DBHelper.GetDataTable(strSql);
                                if (dt.Rows.Count > 0)
                                {
                                    this.comboBox1.DataSource = dt;
                                    this.comboBox1.ValueMember = "CangKuID";
                                    this.comboBox1.DisplayMember = "CangKuMing";
                                }
                                else
                                {
                                    //没有仓库类型
                                    MessageBox.Show("请去添加仓库");
                                    //TODO:跳转到仓库添加窗口
                                }
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
                if (GuZiMing == "" || CangKuID == "" || GuZiShuLiang == "" || GuZiJiaZhi == "" || label5 == "")
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

        private void GudinZiChanyianjia_Load(object sender, EventArgs e)
        {
            bindSelectData();
        }
        private void bindSelectData()
        {

            string strSql = "select CangKuID,CangKuMing from CangKu";
            DataTable dt = DBHelper.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                this.comboBox1.DataSource = dt;
                this.comboBox1.ValueMember = "CangKuID";
                this.comboBox1.DisplayMember = "CangKuMing";
            }
            else
            {
                //没有仓库类型
                MessageBox.Show("请去添加仓库");
                //TODO:跳转到仓库添加窗口
            }
        }
    }
}
