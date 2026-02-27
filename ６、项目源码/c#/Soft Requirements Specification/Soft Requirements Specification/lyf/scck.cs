using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Requirements_Specification.ckgl
{
    public partial class scck : Form
    {
        public scck()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string scckmc = this.textBox1.Text;
            try
            {

                DialogResult sc = MessageBox.Show("请确认是否删除该仓库名称", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (sc == DialogResult.OK)
                {
                    string scmc = $"select * from CangKu where CangKuMing = '{scckmc}' ";
                    DataTable panduan = DBHelper.GetDataTable(scmc);
                    if (panduan.Rows.Count > 0)
                    {
                        string sql = $"delete from CangKu  where CangKuMing = '{scckmc}'  ";
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
                        MessageBox.Show("该仓库不存在，删除失败");
                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                if (scckmc == "")
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
