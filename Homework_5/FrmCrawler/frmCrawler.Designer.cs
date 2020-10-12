namespace FrmCrawler
{
    partial class frmCrawler
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
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.URLGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.URLGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblURL
            // 
            this.lblURL.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblURL.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblURL.Location = new System.Drawing.Point(12, 9);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(78, 23);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "初始URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(96, 9);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(396, 21);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "https://www.cnblog.com/dst2000/";
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnstart.Location = new System.Drawing.Point(542, -1);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(105, 33);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "开始爬取";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // URLGridView
            // 
            this.URLGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.URLGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.URLGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.URLGridView.Location = new System.Drawing.Point(2, 49);
            this.URLGridView.Name = "URLGridView";
            this.URLGridView.RowTemplate.Height = 23;
            this.URLGridView.Size = new System.Drawing.Size(796, 399);
            this.URLGridView.TabIndex = 3;
            // 
            // frmCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.URLGridView);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Name = "frmCrawler";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.URLGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.DataGridView URLGridView;
    }
}

