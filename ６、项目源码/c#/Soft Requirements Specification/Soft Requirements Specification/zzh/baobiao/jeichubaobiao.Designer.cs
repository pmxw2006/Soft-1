namespace Soft_Requirements_Specification.zzh.baobiao
{
    partial class jeichubaobiao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jeichubaobiao));
            this.label1 = new System.Windows.Forms.Label();
            this.nianfen1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.chaxun = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(108, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "请选择最小出厂年份";
            // 
            // nianfen1
            // 
            this.nianfen1.Location = new System.Drawing.Point(285, 581);
            this.nianfen1.Margin = new System.Windows.Forms.Padding(4);
            this.nianfen1.MaxDate = new System.DateTime(2709, 12, 31, 0, 0, 0, 0);
            this.nianfen1.Name = "nianfen1";
            this.nianfen1.Size = new System.Drawing.Size(266, 28);
            this.nianfen1.TabIndex = 21;
            this.nianfen1.Value = new System.DateTime(2025, 5, 8, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 16F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(375, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 76);
            this.button1.TabIndex = 19;
            this.button1.Text = "年份查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chaxun
            // 
            this.chaxun.Font = new System.Drawing.Font("宋体", 16F);
            this.chaxun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chaxun.Location = new System.Drawing.Point(819, 644);
            this.chaxun.Name = "chaxun";
            this.chaxun.Size = new System.Drawing.Size(340, 76);
            this.chaxun.TabIndex = 20;
            this.chaxun.Text = "总查询";
            this.chaxun.UseVisualStyleBackColor = true;
            this.chaxun.Click += new System.EventHandler(this.chaxun_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(39, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1417, 540);
            this.dataGridView1.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "GuZiMing";
            this.Column1.HeaderText = "固定资产名称";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GuZiShuLiang";
            this.Column2.HeaderText = "固定资产数量";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ZuJieGongSi";
            this.Column3.HeaderText = "租借公司";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ZuJieShuLiang";
            this.Column4.HeaderText = "租借数量";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "JeiRiQi";
            this.Column5.HeaderText = "租借日期";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ChuChangRiQi";
            this.Column9.HeaderText = "出厂日期";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // jeichubaobiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 746);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nianfen1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chaxun);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "jeichubaobiao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "固定资产借出报表";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker nianfen1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button chaxun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}