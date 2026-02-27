using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soft_Requirements_Specification.hu;
using Soft_Requirements_Specification.hu.yonghuguanli;

namespace Soft_Requirements_Specification
{
    public partial class zhuti : Form
    {
        public string CurrentUserQuanXian { get; private set; }
        public string CUserZhangHao { get; private set; }
        public zhuti()
        {
            InitializeComponent();
        }
        private void A1_Load(object sender, EventArgs e)
        {//加载过程中登录界面
            denglujiemian n1 = new denglujiemian();
            n1.ShowDialog();
            this.CurrentUserQuanXian = n1.UserQuanXian;
            this.CUserZhangHao = n1.UserZhangHao;
        }

        private void gerenxinxi_Click(object sender, EventArgs e)
        {//个人中心
            hu.gerenzhongxin.xiugaigerenxinxi grxx = new hu.gerenzhongxin.xiugaigerenxinxi(this.CUserZhangHao);
            grxx.ShowDialog();
        }

        private void tuichuzhanghao_Click(object sender, EventArgs e)
        {//退出
            zhuti zhuti = new zhuti();
            this.Hide();
            zhuti.ShowDialog();
        }

        private void zhuti_FormClosed(object sender, FormClosedEventArgs e)
        {//关闭窗体
            Application.Exit();
        }
        private void yonghuguanli_Click(object sender, EventArgs e)
        {//用户管理
            string qx = this.CurrentUserQuanXian;
            if (qx == "管理员部门" || qx == "系统部门")
            {
                yonghuguanli yhgl = new yonghuguanli();
                yhgl.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足无法查看此功能");
            }
        }

        private void zengjiabaobiao_Click(object sender, EventArgs e)
        {
            string qx = this.CurrentUserQuanXian;
            if (qx == "管理员部门" || qx == "固定资产部门")
            {
                hu.baobiao.baobiao a1 = new hu.baobiao.baobiao();
                a1.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足无法查看此功能");
            }
        }

        private void weixiubaobiao_Click(object sender, EventArgs e)
        {
            string qx = this.CurrentUserQuanXian;
            if (qx == "管理员部门" || qx == "固定资产部门")
            {
                hu.baobiao.weixiubaobiao a2 = new hu.baobiao.weixiubaobiao();
                a2.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足无法查看此功能");
            }
        }

        private void jiehuanbaobiao_Click(object sender, EventArgs e)
        {
            string qx = this.CurrentUserQuanXian;
            if (qx == "管理员部门" || qx == "固定资产部门")
            {
                hu.baobiao.guihuanbaobiao a3 = new hu.baobiao.guihuanbaobiao();
                a3.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足无法查看此功能");
            }
        }

        private void jiebaobiao_Click(object sender, EventArgs e)
        {
            string qx = this.CurrentUserQuanXian;
            if (qx == "管理员部门" || qx == "固定资产部门")
            {
                zzh.baobiao.jeichubaobiao a3 = new zzh.baobiao.jeichubaobiao();
                a3.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足无法查看此功能");
            }
        }

        private void jiehuanguanli_Click(object sender, EventArgs e)
        {
            string qx = this.CurrentUserQuanXian;
            if (qx == "管理员部门" || qx == "固定资产部门")
            {
                pjm.gzliebiao b1 = new pjm.gzliebiao();
                b1.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足无法查看此功能");
            }
        }

        private void cangkuguanli_Click(object sender, EventArgs e)
        {
            string qx = this.CurrentUserQuanXian;
            if (qx == "管理员部门" || qx == "系统部门")
            {
                ckgl1 c1 = new ckgl1();
                c1.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足无法查看此功能");
            }
        }

        private void weixiuguanli_Click(object sender, EventArgs e)
        {
            string qx = this.CurrentUserQuanXian;
            if (qx == "管理员部门" || qx == "固定资产部门")
            {
                lzm.WeiXiu d1 = new lzm.WeiXiu();
                d1.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足无法查看此功能");
            }
        }

        private void xinxiguanli_Click(object sender, EventArgs e)
        {
            string qx = this.CurrentUserQuanXian;
            if (qx == "管理员部门" || qx == "固定资产部门")
            {
                lzm.GudinZiChan d2 = new lzm.GudinZiChan();
                d2.ShowDialog();
            }
            else
            {
                MessageBox.Show("您的权限不足无法查看此功能");
            }
        }
    }
}
