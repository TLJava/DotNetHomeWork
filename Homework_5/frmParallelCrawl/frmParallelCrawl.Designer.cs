namespace frmParallelCrawl
{
    partial class frmParallelCrawl
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.UrlGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UrlGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(569, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始爬取 ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.Location = new System.Drawing.Point(33, 18);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(81, 23);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "初始URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(98, 12);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(417, 29);
            this.txtURL.TabIndex = 2;
            this.txtURL.Text = "https://www.taobao.com/";
            // 
            // UrlGridView
            // 
            this.UrlGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UrlGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrlGridView.Location = new System.Drawing.Point(0, 59);
            this.UrlGridView.Name = "UrlGridView";
            this.UrlGridView.Size = new System.Drawing.Size(800, 388);
            this.UrlGridView.TabIndex = 3;
            // 
            // frmParallelCrawl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UrlGridView);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.btnStart);
            this.Name = "frmParallelCrawl";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UrlGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.DataGridView UrlGridView;
    }
}

