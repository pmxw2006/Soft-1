using Soft_Requirements_Specification.ckgl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Requirements_Specification
{
    public partial class ckgl1 : Form
    {
        public ckgl1()
        {
            InitializeComponent();
        }


        private void cangkuguanli_Load(object sender, EventArgs e)
        {
            DataTable chaxun = DBHelper.GetDataTable("select * from  CangKu join LeiXin on CangKu.LeiXingID=LeiXin.LeiXingID");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = chaxun;
        }

        private void tjck_Click(object sender, EventArgs e)
        {
            tjck form1 = new tjck();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scck sc = new scck();
            sc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tjcklx lx = new tjcklx();
            lx.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable chaxun = DBHelper.GetDataTable("select * from  CangKu join LeiXin on CangKu.LeiXingID=LeiXin.LeiXingID");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = chaxun;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lyf.cxcklx Form2 = new lyf.cxcklx();
            Form2.ShowDialog();
        }
    }
}
