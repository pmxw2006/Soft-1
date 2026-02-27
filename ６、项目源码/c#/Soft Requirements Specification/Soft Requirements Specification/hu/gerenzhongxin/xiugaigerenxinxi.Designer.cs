namespace Soft_Requirements_Specification.hu.gerenzhongxin
{
    partial class xiugaigerenxinxi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xiugaigerenxinxi));
            this.shengri = new System.Windows.Forms.Label();
            this.xingmin = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.xinming1 = new System.Windows.Forms.TextBox();
            this.shengri1 = new System.Windows.Forms.DateTimePicker();
            this.bumen = new System.Windows.Forms.Label();
            this.bumen1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shengri
            // 
            this.shengri.AutoSize = true;
            this.shengri.Location = new System.Drawing.Point(45, 98);
            this.shengri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shengri.Name = "shengri";
            this.shengri.Size = new System.Drawing.Size(116, 18);
            this.shengri.TabIndex = 15;
            this.shengri.Text = "出生年月日：";
            // 
            // xingmin
            // 
            this.xingmin.AutoSize = true;
            this.xingmin.Location = new System.Drawing.Point(99, 57);
            this.xingmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xingmin.Name = "xingmin";
            this.xingmin.Size = new System.Drawing.Size(62, 18);
            this.xingmin.TabIndex = 16;
            this.xingmin.Text = "姓名：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 52);
            this.button2.TabIndex = 17;
            this.button2.Text = "修改个人信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // xinming1
            // 
            this.xinming1.Location = new System.Drawing.Point(165, 54);
            this.xinming1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xinming1.Name = "xinming1";
            this.xinming1.Size = new System.Drawing.Size(266, 28);
            this.xinming1.TabIndex = 19;
            // 
            // shengri1
            // 
            this.shengri1.Location = new System.Drawing.Point(165, 90);
            this.shengri1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shengri1.MaxDate = new System.DateTime(2025, 5, 8, 0, 0, 0, 0);
            this.shengri1.Name = "shengri1";
            this.shengri1.Size = new System.Drawing.Size(266, 28);
            this.shengri1.TabIndex = 18;
            this.shengri1.Value = new System.DateTime(2025, 5, 8, 0, 0, 0, 0);
            // 
            // bumen
            // 
            this.bumen.AutoSize = true;
            this.bumen.Location = new System.Drawing.Point(58, 134);
            this.bumen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bumen.Name = "bumen";
            this.bumen.Size = new System.Drawing.Size(98, 18);
            this.bumen.TabIndex = 14;
            this.bumen.Text = "部门权限：";
            // 
            // bumen1
            // 
            this.bumen1.Location = new System.Drawing.Point(165, 130);
            this.bumen1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bumen1.Name = "bumen1";
            this.bumen1.ReadOnly = true;
            this.bumen1.Size = new System.Drawing.Size(266, 28);
            this.bumen1.TabIndex = 20;
            // 
            // xiugaigerenxinxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 282);
            this.Controls.Add(this.bumen1);
            this.Controls.Add(this.xinming1);
            this.Controls.Add(this.shengri1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bumen);
            this.Controls.Add(this.shengri);
            this.Controls.Add(this.xingmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xiugaigerenxinxi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.xiugaigerenxinxi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label shengri;
        private System.Windows.Forms.Label xingmin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox xinming1;
        private System.Windows.Forms.DateTimePicker shengri1;
        private System.Windows.Forms.Label bumen;
        private System.Windows.Forms.TextBox bumen1;
    }
}