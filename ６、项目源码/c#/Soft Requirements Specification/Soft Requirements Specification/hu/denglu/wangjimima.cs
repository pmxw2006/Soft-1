using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Soft_Requirements_Specification
{
    public partial class wangjimima : Form
    {
        public wangjimima()
        {
            InitializeComponent();
        }

        private void xgmm_Click(object sender, EventArgs e)
        {
            string zhanghao = this.zhanghao1.Text;
            string xingming = this.xinming1.Text;
            string shengri = this.shengri1.Text;
            string mima = this.mima1.Text;
            string mima1 = this.mima2.Text;
            DateTime shengri1 = DateTime.Parse(shengri);
            DialogResult c;
            c = MessageBox.Show("请确认是否修改密码", "修改密码提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (c == DialogResult.OK)
            {
                if (zhanghao == "" || xingming == "" || shengri == "" || mima == "")
                {
                    MessageBox.Show("基本信息有空");
                }
                else if (mima!=mima1)
                {
                    MessageBox.Show("密码与确认密码不一致请重新输入");
                }
                else
                {
                    try
                    {
                        string mimajiami;
                        using (SHA256 sha256Hash = SHA256.Create())
                        {
                            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(mima));
                            StringBuilder builder = new StringBuilder();
                            for (int i = 0; i < bytes.Length; i++)
                            {
                                builder.Append(bytes[i].ToString("x2"));
                            }
                            mimajiami = builder.ToString();
                        }
                        string sql = $"select * from YongHu where YongHuID ='{zhanghao}' and XingMing = '{xingming}' and ShengRi = '{shengri1}'";
                        DataTable panduan = DBHelper.GetDataTable(sql);
                        if (panduan.Rows.Count > 0)
                        {
                            string sql1 = $"update YongHu set MiMa = '{mimajiami}' where YongHuID ='{zhanghao}'";
                            DataTable panduan1 = DBHelper.GetDataTable(sql1);
                            this.Hide();
                            MessageBox.Show("修改成功");
                        }
                        else
                        {
                            MessageBox.Show("基本信息有误");
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("基本信息有误");
                    }
                    finally
                    {

                    }
                }
            }
            else
            {

            }
        }
    }
}
