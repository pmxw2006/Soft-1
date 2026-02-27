
namespace Soft_Requirements_Specification.lzm
{
    partial class GudinZiChan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GudinZiChan));
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GuZiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuZiMing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CangKuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuZiShuLiang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuZiJiaZhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuChangRiQi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZhuangTaiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(18, 582);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(177, 75);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuZiID,
            this.GuZiMing,
            this.CangKuID,
            this.GuZiShuLiang,
            this.GuZiJiaZhi,
            this.ChuChangRiQi,
            this.ZhuangTaiID});
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 548);
            this.dataGridView1.TabIndex = 3;
            // 
            // GuZiID
            // 
            this.GuZiID.DataPropertyName = "GuZiID";
            this.GuZiID.HeaderText = "固定资产ID";
            this.GuZiID.MinimumWidth = 8;
            this.GuZiID.Name = "GuZiID";
            this.GuZiID.ReadOnly = true;
            this.GuZiID.Width = 150;
            // 
            // GuZiMing
            // 
            this.GuZiMing.DataPropertyName = "GuZiMing";
            this.GuZiMing.HeaderText = "固定资产名称";
            this.GuZiMing.MinimumWidth = 8;
            this.GuZiMing.Name = "GuZiMing";
            this.GuZiMing.ReadOnly = true;
            this.GuZiMing.Width = 150;
            // 
            // CangKuID
            // 
            this.CangKuID.DataPropertyName = "CangKuID";
            this.CangKuID.HeaderText = "仓库ID";
            this.CangKuID.MinimumWidth = 8;
            this.CangKuID.Name = "CangKuID";
            this.CangKuID.ReadOnly = true;
            this.CangKuID.Width = 150;
            // 
            // GuZiShuLiang
            // 
            this.GuZiShuLiang.DataPropertyName = "GuZiShuLiang";
            this.GuZiShuLiang.HeaderText = "固定资产数量";
            this.GuZiShuLiang.MinimumWidth = 8;
            this.GuZiShuLiang.Name = "GuZiShuLiang";
            this.GuZiShuLiang.ReadOnly = true;
            this.GuZiShuLiang.Width = 150;
            // 
            // GuZiJiaZhi
            // 
            this.GuZiJiaZhi.DataPropertyName = "GuZiJiaZhi";
            this.GuZiJiaZhi.HeaderText = "固定资产价值";
            this.GuZiJiaZhi.MinimumWidth = 8;
            this.GuZiJiaZhi.Name = "GuZiJiaZhi";
            this.GuZiJiaZhi.ReadOnly = true;
            this.GuZiJiaZhi.Width = 150;
            // 
            // ChuChangRiQi
            // 
            this.ChuChangRiQi.DataPropertyName = "ChuChangRiQi";
            this.ChuChangRiQi.HeaderText = "出厂日期";
            this.ChuChangRiQi.MinimumWidth = 8;
            this.ChuChangRiQi.Name = "ChuChangRiQi";
            this.ChuChangRiQi.ReadOnly = true;
            this.ChuChangRiQi.Width = 150;
            // 
            // ZhuangTaiID
            // 
            this.ZhuangTaiID.DataPropertyName = "ZhuangTaiID";
            this.ZhuangTaiID.HeaderText = "状态ID ";
            this.ZhuangTaiID.MinimumWidth = 8;
            this.ZhuangTaiID.Name = "ZhuangTaiID";
            this.ZhuangTaiID.ReadOnly = true;
            this.ZhuangTaiID.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 609);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(864, 609);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(986, 612);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 28);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "请输入需删除的名称";
            // 
            // GudinZiChan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GudinZiChan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "固定资产信息";
            this.Load += new System.EventHandler(this.GudinZiChan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuZiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuZiMing;
        private System.Windows.Forms.DataGridViewTextBoxColumn CangKuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuZiShuLiang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuZiJiaZhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuChangRiQi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZhuangTaiID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
    }
}