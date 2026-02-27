
namespace Soft_Requirements_Specification.pjm
{
    partial class gzliebiao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gzliebiao));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jhtj = new System.Windows.Forms.Button();
            this.jhcx = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bhcx = new System.Windows.Forms.Label();
            this.ghtj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(18, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 528);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "GuZiID";
            this.Column1.HeaderText = "固定资产编号";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GuZiMing";
            this.Column2.HeaderText = "固定资产名称";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GuZiShuLiang";
            this.Column3.HeaderText = "固定资产数量";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GuZiJiaZhi";
            this.Column4.HeaderText = "固定资产价值";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ZuJieGongSi";
            this.Column5.HeaderText = "租借公司";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "JeiRiQi";
            this.Column6.HeaderText = "租借日期";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ZuJieShuLiang";
            this.Column7.HeaderText = "租借数量";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "HuanRiQi";
            this.Column8.HeaderText = "归还日期";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // jhtj
            // 
            this.jhtj.Location = new System.Drawing.Point(18, 555);
            this.jhtj.Margin = new System.Windows.Forms.Padding(4);
            this.jhtj.Name = "jhtj";
            this.jhtj.Size = new System.Drawing.Size(112, 34);
            this.jhtj.TabIndex = 1;
            this.jhtj.Text = "借出添加";
            this.jhtj.UseVisualStyleBackColor = true;
            this.jhtj.Click += new System.EventHandler(this.jhtj_Click);
            // 
            // jhcx
            // 
            this.jhcx.Location = new System.Drawing.Point(792, 597);
            this.jhcx.Margin = new System.Windows.Forms.Padding(4);
            this.jhcx.Name = "jhcx";
            this.jhcx.Size = new System.Drawing.Size(112, 34);
            this.jhcx.TabIndex = 2;
            this.jhcx.Text = "查询归还";
            this.jhcx.UseVisualStyleBackColor = true;
            this.jhcx.Click += new System.EventHandler(this.jhcx_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(633, 561);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 28);
            this.textBox1.TabIndex = 3;
            // 
            // bhcx
            // 
            this.bhcx.AutoSize = true;
            this.bhcx.Location = new System.Drawing.Point(491, 564);
            this.bhcx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bhcx.Name = "bhcx";
            this.bhcx.Size = new System.Drawing.Size(134, 18);
            this.bhcx.TabIndex = 4;
            this.bhcx.Text = "固定资产名称：";
            // 
            // ghtj
            // 
            this.ghtj.Location = new System.Drawing.Point(156, 555);
            this.ghtj.Margin = new System.Windows.Forms.Padding(4);
            this.ghtj.Name = "ghtj";
            this.ghtj.Size = new System.Drawing.Size(112, 34);
            this.ghtj.TabIndex = 1;
            this.ghtj.Text = "归还添加";
            this.ghtj.UseVisualStyleBackColor = true;
            this.ghtj.Click += new System.EventHandler(this.ghtj_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询借出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gzliebiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 712);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bhcx);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.jhcx);
            this.Controls.Add(this.ghtj);
            this.Controls.Add(this.jhtj);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gzliebiao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "借还查询";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button jhtj;
        private System.Windows.Forms.Button jhcx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label bhcx;
        private System.Windows.Forms.Button ghtj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button button1;
    }
}