
namespace Soft_Requirements_Specification.lzm
{
    partial class WeiXiu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeiXiu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GuZiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeiXiuShuLiang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongXiuRiQi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YuWanRiQi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiWanRiQi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeiXiuJinE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuZiID,
            this.WeiXiuShuLiang,
            this.SongXiuRiQi,
            this.YuWanRiQi,
            this.ShiWanRiQi,
            this.WeiXiuJinE});
            this.dataGridView1.Location = new System.Drawing.Point(20, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 537);
            this.dataGridView1.TabIndex = 0;
            // 
            // GuZiID
            // 
            this.GuZiID.DataPropertyName = "GuZiMing";
            this.GuZiID.HeaderText = "固定资产名称";
            this.GuZiID.MinimumWidth = 8;
            this.GuZiID.Name = "GuZiID";
            this.GuZiID.ReadOnly = true;
            this.GuZiID.Width = 150;
            // 
            // WeiXiuShuLiang
            // 
            this.WeiXiuShuLiang.DataPropertyName = "WeiXiuShuLiang";
            this.WeiXiuShuLiang.HeaderText = "维修数量";
            this.WeiXiuShuLiang.MinimumWidth = 8;
            this.WeiXiuShuLiang.Name = "WeiXiuShuLiang";
            this.WeiXiuShuLiang.ReadOnly = true;
            this.WeiXiuShuLiang.Width = 150;
            // 
            // SongXiuRiQi
            // 
            this.SongXiuRiQi.DataPropertyName = "SongXiuRiQi";
            this.SongXiuRiQi.HeaderText = "送修日期";
            this.SongXiuRiQi.MinimumWidth = 8;
            this.SongXiuRiQi.Name = "SongXiuRiQi";
            this.SongXiuRiQi.ReadOnly = true;
            this.SongXiuRiQi.Width = 150;
            // 
            // YuWanRiQi
            // 
            this.YuWanRiQi.DataPropertyName = "YuWanRiQi";
            this.YuWanRiQi.HeaderText = "预期完成日期";
            this.YuWanRiQi.MinimumWidth = 8;
            this.YuWanRiQi.Name = "YuWanRiQi";
            this.YuWanRiQi.ReadOnly = true;
            this.YuWanRiQi.Width = 150;
            // 
            // ShiWanRiQi
            // 
            this.ShiWanRiQi.DataPropertyName = "ShiWanRiQi";
            this.ShiWanRiQi.HeaderText = "实际完修日期";
            this.ShiWanRiQi.MinimumWidth = 8;
            this.ShiWanRiQi.Name = "ShiWanRiQi";
            this.ShiWanRiQi.ReadOnly = true;
            this.ShiWanRiQi.Width = 150;
            // 
            // WeiXiuJinE
            // 
            this.WeiXiuJinE.DataPropertyName = "WeiXiuJinE";
            this.WeiXiuJinE.HeaderText = "维修金额";
            this.WeiXiuJinE.MinimumWidth = 8;
            this.WeiXiuJinE.Name = "WeiXiuJinE";
            this.WeiXiuJinE.ReadOnly = true;
            this.WeiXiuJinE.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 588);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "添加维修";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 584);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 74);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1022, 592);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 70);
            this.button2.TabIndex = 8;
            this.button2.Text = "添加完修日期";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WeiXiu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WeiXiu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "固定资产维修";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuZiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeiXiuShuLiang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongXiuRiQi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YuWanRiQi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiWanRiQi;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeiXiuJinE;
        private System.Windows.Forms.Button button2;
    }
}