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
    public partial class GudinZiChan : Form
    {
        public GudinZiChan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable chaxun = DBHelper.GetDataTable("select * from GudinZiChan");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = chaxun;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gzmc = this.textBox2.Text;
            DialogResult c;
            c = MessageBox.Show("请确认是否删除", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (c == DialogResult.OK)
            {
                string sql1 = $"select * from GudinZiChan where GuZiMing = '{gzmc}' ";
                DataTable panduan = DBHelper.GetDataTable(sql1);
                if (panduan.Rows.Count > 0)
                {
                    string sql = $"delete from GudinZiChan  where GuZiMing = '{gzmc}'  ";
                    bool panduan1 = DBHelper.ExcNonQuery(sql);
                    if (panduan1)
                    {
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
                else
                {
                    MessageBox.Show("该固定资产不存在，删除失败");
                }
            }
            else
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GudinZiChanyianjia GudinZiChanyianjia = new GudinZiChanyianjia();
            GudinZiChanyianjia.ShowDialog();
        }

        private void GudinZiChan_Load(object sender, EventArgs e)
        {

        }
    }
}
