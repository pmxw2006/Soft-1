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
    public partial class tjcklx : Form
    {
        public tjcklx()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tjcklx = this.textBox1.Text;
            try
            {

                DialogResult tj = MessageBox.Show("请确认是否添加该仓库类型", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (tj == DialogResult.OK)
                {
                    string sql1 = $"select * from  LeiXin where LeiXingI='{tjcklx}'";
                    DataTable panduan = DBHelper.GetDataTable(sql1);
                    if (panduan.Rows.Count > 0)
                    {
                        MessageBox.Show("类型重复");
                    }
                    else
                    {
                        string sql = $"insert  LeiXin(LeiXingI) values('{tjcklx}')";
                        bool panduan1 = DBHelper.ExcNonQuery(sql);
                        if (panduan1)
                        {
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("添加失败");
                        }
                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                if (tjcklx == "")
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
