namespace Soft_Requirements_Specification
{
    partial class denglujiemian
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(denglujiemian));
            this.yonghu = new System.Windows.Forms.Label();
            this.mima1 = new System.Windows.Forms.TextBox();
            this.mima = new System.Windows.Forms.Label();
            this.quanxian = new System.Windows.Forms.Label();
            this.quanxian1 = new System.Windows.Forms.ComboBox();
            this.yonghu1 = new System.Windows.Forms.TextBox();
            this.querendenglu = new System.Windows.Forms.Button();
            this.wjmm = new System.Windows.Forms.Button();
            this.cjzh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yonghu
            // 
            this.yonghu.AutoSize = true;
            this.yonghu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yonghu.Location = new System.Drawing.Point(112, 123);
            this.yonghu.Name = "yonghu";
            this.yonghu.Size = new System.Drawing.Size(106, 24);
            this.yonghu.TabIndex = 1;
            this.yonghu.Text = "账  号：";
            // 
            // mima1
            // 
            this.mima1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mima1.Location = new System.Drawing.Point(226, 174);
            this.mima1.Name = "mima1";
            this.mima1.PasswordChar = '*';
            this.mima1.Size = new System.Drawing.Size(230, 35);
            this.mima1.TabIndex = 0;
            // 
            // mima
            // 
            this.mima.AutoSize = true;
            this.mima.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mima.Location = new System.Drawing.Point(112, 178);
            this.mima.Name = "mima";
            this.mima.Size = new System.Drawing.Size(106, 24);
            this.mima.TabIndex = 1;
            this.mima.Text = "密  码：";
            // 
            // quanxian
            // 
            this.quanxian.AutoSize = true;
            this.quanxian.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quanxian.Location = new System.Drawing.Point(16, 21);
            this.quanxian.Name = "quanxian";
            this.quanxian.Size = new System.Drawing.Size(106, 24);
            this.quanxian.TabIndex = 1;
            this.quanxian.Text = "权  限：";
            // 
            // quanxian1
            // 
            this.quanxian1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quanxian1.Font = new System.Drawing.Font("宋体", 10F);
            this.quanxian1.FormattingEnabled = true;
            this.quanxian1.Items.AddRange(new object[] {
            "管理员部门",
            "系统部门",
            "固定资产部门"});
            this.quanxian1.Location = new System.Drawing.Point(117, 16);
            this.quanxian1.MaxDropDownItems = 2;
            this.quanxian1.Name = "quanxian1";
            this.quanxian1.Size = new System.Drawing.Size(157, 28);
            this.quanxian1.TabIndex = 2;
            // 
            // yonghu1
            // 
            this.yonghu1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yonghu1.Location = new System.Drawing.Point(226, 118);
            this.yonghu1.Name = "yonghu1";
            this.yonghu1.Size = new System.Drawing.Size(230, 35);
            this.yonghu1.TabIndex = 0;
            // 
            // querendenglu
            // 
            this.querendenglu.Font = new System.Drawing.Font("宋体", 12F);
            this.querendenglu.Location = new System.Drawing.Point(130, 264);
            this.querendenglu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.querendenglu.Name = "querendenglu";
            this.querendenglu.Size = new System.Drawing.Size(308, 58);
            this.querendenglu.TabIndex = 3;
            this.querendenglu.Text = "确认登录";
            this.querendenglu.UseVisualStyleBackColor = true;
            this.querendenglu.Click += new System.EventHandler(this.button1_Click);
            // 
            // wjmm
            // 
            this.wjmm.Font = new System.Drawing.Font("宋体", 8F);
            this.wjmm.Location = new System.Drawing.Point(369, 220);
            this.wjmm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wjmm.Name = "wjmm";
            this.wjmm.Size = new System.Drawing.Size(90, 34);
            this.wjmm.TabIndex = 3;
            this.wjmm.Text = "忘记密码";
            this.wjmm.UseVisualStyleBackColor = true;
            this.wjmm.Click += new System.EventHandler(this.button2_Click);
            // 
            // cjzh
            // 
            this.cjzh.Font = new System.Drawing.Font("宋体", 8F);
            this.cjzh.Location = new System.Drawing.Point(117, 220);
            this.cjzh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cjzh.Name = "cjzh";
            this.cjzh.Size = new System.Drawing.Size(90, 34);
            this.cjzh.TabIndex = 3;
            this.cjzh.Text = "创建账号";
            this.cjzh.UseVisualStyleBackColor = true;
            this.cjzh.Click += new System.EventHandler(this.button3_Click);
            // 
            // denglujiemian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 340);
            this.Controls.Add(this.cjzh);
            this.Controls.Add(this.wjmm);
            this.Controls.Add(this.querendenglu);
            this.Controls.Add(this.quanxian1);
            this.Controls.Add(this.quanxian);
            this.Controls.Add(this.mima);
            this.Controls.Add(this.yonghu);
            this.Controls.Add(this.yonghu1);
            this.Controls.Add(this.mima1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "denglujiemian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.denglujiemian_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label yonghu;
        private System.Windows.Forms.TextBox mima1;
        private System.Windows.Forms.Label mima;
        private System.Windows.Forms.Label quanxian;
        private System.Windows.Forms.Button querendenglu;
        private System.Windows.Forms.Button wjmm;
        private System.Windows.Forms.Button cjzh;
        public System.Windows.Forms.ComboBox quanxian1;
        public System.Windows.Forms.TextBox yonghu1;
    }
}

