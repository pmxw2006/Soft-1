using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;

namespace Soft_Requirements_Specification
{
    public partial class denglujiemian : Form
    {
        public string UserQuanXian { get; private set; } // 新增属性存储权限
        public string UserZhangHao { get; private set; } // 新增属性存储账号
        public denglujiemian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string quanxian = this.quanxian1.Text;
            string zhanghao = this.yonghu1.Text;
            string mima = this.mima1.Text;
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
                DialogResult c;
                c = MessageBox.Show("请确认是否登录", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (c == DialogResult.OK)
                {
                    // 使用参数化查询防止SQL注入
                    string sql = "select * from YongHu where YongHuID = @zhanghao and MiMa = @mimajiami and BuMen = @quanxian";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "@zhanghao", zhanghao },
                        { "@mimajiami", mimajiami },
                        { "@quanxian", quanxian }
                    };

                    DataTable panduan = DBHelper.GetDataTable(sql, parameters);
                    if (panduan.Rows.Count > 0)
                    {
                        this.UserZhangHao = zhanghao;
                        this.UserQuanXian = quanxian;
                        this.Hide();
                    }
                    else if (zhanghao == "" || mima == "" || quanxian == "")
                    {
                        MessageBox.Show("请输入账号密码或选择权限");
                    }
                    else
                    {
                        MessageBox.Show("账号密码或权限错误请重新输入");
                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                if (zhanghao == "" || mima == "" || quanxian == "")
                {
                    MessageBox.Show("请输入账号密码或选择权限");
                }
                else
                {
                    MessageBox.Show("账号密码或权限错误请重新输入");
                }
            }
            finally
            {

            }
        }
        private void denglujiemian_FormClosed(object sender, FormClosedEventArgs e)
        {//关闭窗体
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {//创建账户
            changjianzhanghu cjzh = new changjianzhanghu();
            DialogResult c;
            c = MessageBox.Show("请确认是否创建账号", "创建账号提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (c == DialogResult.OK)
            {
                cjzh.ShowDialog();
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//忘记密码
            wangjimima wjmm = new wangjimima();
            DialogResult c;
            c = MessageBox.Show("请确认是否忘记密码", "忘记密码提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (c == DialogResult.OK)
            {
                wjmm.ShowDialog();
            }
            else
            {

            }
        }
    }
}
