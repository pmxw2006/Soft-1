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

namespace Soft_Requirements_Specification.hu.yonghuguanli
{
    public partial class yonghuguanli : Form
    {
        public yonghuguanli()
        {
            InitializeComponent();
        }
        private void yonghuguanli_Load(object sender, EventArgs e)
        {
            DataTable chaxun = DBHelper.GetDataTable("select * from YongHu");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = chaxun;
        }
        private void button3_Click(object sender, EventArgs e)
        {//删除
            string xingming = this.xinming1.Text;
            try
            {

                DialogResult c;
                c = MessageBox.Show("请确认是否删除该账号", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (c == DialogResult.OK)
                {
                    string sql1 = $"select * from YongHu where XingMing = '{xingming}' ";
                    DataTable panduan = DBHelper.GetDataTable(sql1);
                    if (panduan.Rows.Count > 0)
                    {
                        string sql = $"delete from YongHu  where XingMing = '{xingming}'  ";
                        bool panduan1 = DBHelper.ExcNonQuery(sql);
                        if (panduan1)
                        {
                            MessageBox.Show("删除成功");
                            DataTable chaxun = DBHelper.GetDataTable("select * from YongHu");
                            this.dataGridView1.DataSource = chaxun;
                        }
                        else
                        {
                            MessageBox.Show("删除失败");
                        }
                    }
                    else
                    {
                        MessageBox.Show("该名称不存在，删除失败");
                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                if (xingming == "")
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
