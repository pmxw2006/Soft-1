using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Requirements_Specification.pjm
{
    public partial class gzliebiao : Form
    {
        public gzliebiao()
        {
            InitializeComponent();
        }

        private void jhcx_Click(object sender, EventArgs e)
        {
            string a = this.textBox1.Text;
            if (a == "")
            {
                DataTable jhcx = DBHelper.GetDataTable($"select * from  GudinZiChan join Jei on Jei.GuZiID=GudinZiChan.GuZiID join Huan on Huan.GuZiID=Jei.GuZiID and Huan.GuiHuanGongSi = Jei.ZuJieGongSi");
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = jhcx;
            }
            else
            {
                DataTable jhcx = DBHelper.GetDataTable($"select * from  GudinZiChan join Jei on Jei.GuZiID=GudinZiChan.GuZiID join Huan on Huan.GuZiID=Jei.GuZiID and Huan.GuiHuanGongSi = Jei.ZuJieGongSi where GuZiMing ='{a}'");
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = jhcx;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = this.textBox1.Text;
            if (a == "")
            {
                DataTable jhcx = DBHelper.GetDataTable($"select * from  GudinZiChan join Jei on Jei.GuZiID=GudinZiChan.GuZiID ");
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = jhcx;
            }
            else
            {
                DataTable jhcx = DBHelper.GetDataTable($"select * from  GudinZiChan join Jei on Jei.GuZiID=GudinZiChan.GuZiID where GuZiMing ='{a}'");
                this.dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = jhcx;
            }
        }
        private void jhtj_Click(object sender, EventArgs e)
        {
            gzjhtj a = new gzjhtj();
            a.ShowDialog();
        }

        private void ghtj_Click(object sender, EventArgs e)
        {
            gzghtj a = new gzghtj();
            a.ShowDialog();
        }
    }
}
