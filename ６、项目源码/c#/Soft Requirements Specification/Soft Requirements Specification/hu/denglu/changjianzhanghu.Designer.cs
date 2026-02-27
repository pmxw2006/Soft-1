namespace Soft_Requirements_Specification
{
    partial class changjianzhanghu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changjianzhanghu));
            this.shengri1 = new System.Windows.Forms.DateTimePicker();
            this.xinming1 = new System.Windows.Forms.TextBox();
            this.mima1 = new System.Windows.Forms.TextBox();
            this.xingmin = new System.Windows.Forms.Label();
            this.mima = new System.Windows.Forms.Label();
            this.shengri = new System.Windows.Forms.Label();
            this.bumen = new System.Windows.Forms.Label();
            this.bumen1 = new System.Windows.Forms.ComboBox();
            this.cjzh = new System.Windows.Forms.Button();
            this.mima2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shengri1
            // 
            this.shengri1.Location = new System.Drawing.Point(138, 94);
            this.shengri1.MaxDate = new System.DateTime(2025, 5, 8, 0, 0, 0, 0);
            this.shengri1.Name = "shengri1";
            this.shengri1.Size = new System.Drawing.Size(179, 21);
            this.shengri1.TabIndex = 0;
            this.shengri1.Value = new System.DateTime(2025, 5, 8, 0, 0, 0, 0);
            // 
            // xinming1
            // 
            this.xinming1.Location = new System.Drawing.Point(138, 12);
            this.xinming1.Name = "xinming1";
            this.xinming1.Size = new System.Drawing.Size(179, 21);
            this.xinming1.TabIndex = 1;
            // 
            // mima1
            // 
            this.mima1.Location = new System.Drawing.Point(138, 40);
            this.mima1.Name = "mima1";
            this.mima1.PasswordChar = '*';
            this.mima1.Size = new System.Drawing.Size(179, 21);
            this.mima1.TabIndex = 1;
            // 
            // xingmin
            // 
            this.xingmin.AutoSize = true;
            this.xingmin.Location = new System.Drawing.Point(91, 12);
            this.xingmin.Name = "xingmin";
            this.xingmin.Size = new System.Drawing.Size(41, 12);
            this.xingmin.TabIndex = 2;
            this.xingmin.Text = "姓名：";
            // 
            // mima
            // 
            this.mima.AutoSize = true;
            this.mima.Location = new System.Drawing.Point(91, 43);
            this.mima.Name = "mima";
            this.mima.Size = new System.Drawing.Size(41, 12);
            this.mima.TabIndex = 2;
            this.mima.Text = "密码：";
            // 
            // shengri
            // 
            this.shengri.AutoSize = true;
            this.shengri.Location = new System.Drawing.Point(55, 100);
            this.shengri.Name = "shengri";
            this.shengri.Size = new System.Drawing.Size(77, 12);
            this.shengri.TabIndex = 2;
            this.shengri.Text = "出生年月日：";
            // 
            // bumen
            // 
            this.bumen.AutoSize = true;
            this.bumen.Location = new System.Drawing.Point(67, 124);
            this.bumen.Name = "bumen";
            this.bumen.Size = new System.Drawing.Size(65, 12);
            this.bumen.TabIndex = 2;
            this.bumen.Text = "部门权限：";
            // 
            // bumen1
            // 
            this.bumen1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bumen1.FormattingEnabled = true;
            this.bumen1.Items.AddRange(new object[] {
            "管理员部门",
            "系统部门",
            "固定资产部门"});
            this.bumen1.Location = new System.Drawing.Point(138, 121);
            this.bumen1.Name = "bumen1";
            this.bumen1.Size = new System.Drawing.Size(179, 20);
            this.bumen1.TabIndex = 3;
            // 
            // cjzh
            // 
            this.cjzh.Location = new System.Drawing.Point(138, 168);
            this.cjzh.Name = "cjzh";
            this.cjzh.Size = new System.Drawing.Size(152, 30);
            this.cjzh.TabIndex = 4;
            this.cjzh.Text = "创建账号";
            this.cjzh.UseVisualStyleBackColor = true;
            this.cjzh.Click += new System.EventHandler(this.cjzh_Click);
            // 
            // mima2
            // 
            this.mima2.Location = new System.Drawing.Point(138, 67);
            this.mima2.Name = "mima2";
            this.mima2.PasswordChar = '*';
            this.mima2.Size = new System.Drawing.Size(179, 21);
            this.mima2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "确认密码：";
            // 
            // changjianzhanghu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 230);
            this.Controls.Add(this.cjzh);
            this.Controls.Add(this.bumen1);
            this.Controls.Add(this.bumen);
            this.Controls.Add(this.shengri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mima);
            this.Controls.Add(this.xingmin);
            this.Controls.Add(this.mima2);
            this.Controls.Add(this.mima1);
            this.Controls.Add(this.xinming1);
            this.Controls.Add(this.shengri1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "changjianzhanghu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建账户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker shengri1;
        private System.Windows.Forms.TextBox xinming1;
        private System.Windows.Forms.TextBox mima1;
        private System.Windows.Forms.Label xingmin;
        private System.Windows.Forms.Label mima;
        private System.Windows.Forms.Label shengri;
        private System.Windows.Forms.Label bumen;
        private System.Windows.Forms.ComboBox bumen1;
        private System.Windows.Forms.Button cjzh;
        private System.Windows.Forms.TextBox mima2;
        private System.Windows.Forms.Label label1;
    }
}