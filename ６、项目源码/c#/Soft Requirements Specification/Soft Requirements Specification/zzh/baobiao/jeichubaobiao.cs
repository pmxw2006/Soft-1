using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Requirements_Specification.zzh.baobiao
{
    public partial class jeichubaobiao : Form
    {
        public jeichubaobiao()
        {
            InitializeComponent();
        }

        private void chaxun_Click(object sender, EventArgs e)
        {
            DataTable chaxun = DBHelper.GetDataTable("select * from  GudinZiChan join Jei on GudinZiChan.GuZiID=Jei.GuZiID");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = chaxun;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nianfen = this.nianfen1.Text;
            DateTime nianfen1 = DateTime.Parse(nianfen);
            DataTable chaxun = DBHelper.GetDataTable($"select * from  GudinZiChan join Jei on GudinZiChan.GuZiID=Jei.GuZiID where ChuChangRiQi >  '{nianfen1}';");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = chaxun;
        }

    }
}
