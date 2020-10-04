namespace CaleyTree
{
    partial class Form1
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
            this.btndraw = new System.Windows.Forms.Button();
            this.lbldeep = new System.Windows.Forms.Label();
            this.lbllength = new System.Windows.Forms.Label();
            this.lblper1 = new System.Windows.Forms.Label();
            this.lblper2 = new System.Windows.Forms.Label();
            this.lblrightangle = new System.Windows.Forms.Label();
            this.lblleftangle = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.txtdeep = new System.Windows.Forms.TextBox();
            this.txtlength = new System.Windows.Forms.TextBox();
            this.txtrightlen = new System.Windows.Forms.TextBox();
            this.txtleftlen = new System.Windows.Forms.TextBox();
            this.txtrightangle = new System.Windows.Forms.TextBox();
            this.txtleftangle = new System.Windows.Forms.TextBox();
            this.cbxcolor = new System.Windows.Forms.ComboBox();
            this.paneltree = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btndraw
            // 
            this.btndraw.Location = new System.Drawing.Point(621, 12);
            this.btndraw.Name = "btndraw";
            this.btndraw.Size = new System.Drawing.Size(75, 23);
            this.btndraw.TabIndex = 0;
            this.btndraw.Text = "draw";
            this.btndraw.UseVisualStyleBackColor = true;
            this.btndraw.Click += new System.EventHandler(this.btndraw_Click);
            // 
            // lbldeep
            // 
            this.lbldeep.AutoSize = true;
            this.lbldeep.Location = new System.Drawing.Point(579, 67);
            this.lbldeep.Name = "lbldeep";
            this.lbldeep.Size = new System.Drawing.Size(53, 12);
            this.lbldeep.TabIndex = 1;
            this.lbldeep.Text = "递归深度";
            // 
            // lbllength
            // 
            this.lbllength.AutoSize = true;
            this.lbllength.Location = new System.Drawing.Point(579, 106);
            this.lbllength.Name = "lbllength";
            this.lbllength.Size = new System.Drawing.Size(53, 12);
            this.lbllength.TabIndex = 2;
            this.lbllength.Text = "主干长度";
            // 
            // lblper1
            // 
            this.lblper1.AutoSize = true;
            this.lblper1.Location = new System.Drawing.Point(579, 141);
            this.lblper1.Name = "lblper1";
            this.lblper1.Size = new System.Drawing.Size(53, 12);
            this.lblper1.TabIndex = 3;
            this.lblper1.Text = "右分支比";
            // 
            // lblper2
            // 
            this.lblper2.AutoSize = true;
            this.lblper2.Location = new System.Drawing.Point(579, 177);
            this.lblper2.Name = "lblper2";
            this.lblper2.Size = new System.Drawing.Size(53, 12);
            this.lblper2.TabIndex = 4;
            this.lblper2.Text = "左分支比";
            // 
            // lblrightangle
            // 
            this.lblrightangle.AutoSize = true;
            this.lblrightangle.Location = new System.Drawing.Point(579, 220);
            this.lblrightangle.Name = "lblrightangle";
            this.lblrightangle.Size = new System.Drawing.Size(65, 12);
            this.lblrightangle.TabIndex = 5;
            this.lblrightangle.Text = "右分支角度";
            // 
            // lblleftangle
            // 
            this.lblleftangle.AutoSize = true;
            this.lblleftangle.Location = new System.Drawing.Point(579, 261);
            this.lblleftangle.Name = "lblleftangle";
            this.lblleftangle.Size = new System.Drawing.Size(65, 12);
            this.lblleftangle.TabIndex = 6;
            this.lblleftangle.Text = "左分支角度";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(579, 301);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(53, 12);
            this.lblcolor.TabIndex = 7;
            this.lblcolor.Text = "画笔颜色";
            // 
            // txtdeep
            // 
            this.txtdeep.Location = new System.Drawing.Point(670, 64);
            this.txtdeep.Name = "txtdeep";
            this.txtdeep.Size = new System.Drawing.Size(100, 21);
            this.txtdeep.TabIndex = 8;
            // 
            // txtlength
            // 
            this.txtlength.Location = new System.Drawing.Point(670, 97);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(100, 21);
            this.txtlength.TabIndex = 9;
            // 
            // txtrightlen
            // 
            this.txtrightlen.Location = new System.Drawing.Point(670, 138);
            this.txtrightlen.Name = "txtrightlen";
            this.txtrightlen.Size = new System.Drawing.Size(100, 21);
            this.txtrightlen.TabIndex = 10;
            // 
            // txtleftlen
            // 
            this.txtleftlen.Location = new System.Drawing.Point(670, 174);
            this.txtleftlen.Name = "txtleftlen";
            this.txtleftlen.Size = new System.Drawing.Size(100, 21);
            this.txtleftlen.TabIndex = 11;
            // 
            // txtrightangle
            // 
            this.txtrightangle.Location = new System.Drawing.Point(670, 211);
            this.txtrightangle.Name = "txtrightangle";
            this.txtrightangle.Size = new System.Drawing.Size(100, 21);
            this.txtrightangle.TabIndex = 12;
            // 
            // txtleftangle
            // 
            this.txtleftangle.Location = new System.Drawing.Point(670, 252);
            this.txtleftangle.Name = "txtleftangle";
            this.txtleftangle.Size = new System.Drawing.Size(100, 21);
            this.txtleftangle.TabIndex = 13;
            // 
            // cbxcolor
            // 
            this.cbxcolor.FormattingEnabled = true;
            this.cbxcolor.Items.AddRange(new object[] {
            "蓝色",
            "绿色",
            "黄色",
            "红色",
            "棕色"});
            this.cbxcolor.Location = new System.Drawing.Point(670, 293);
            this.cbxcolor.Name = "cbxcolor";
            this.cbxcolor.Size = new System.Drawing.Size(121, 20);
            this.cbxcolor.TabIndex = 14;
            this.cbxcolor.Text = "选择颜色";
            // 
            // paneltree
            // 
            this.paneltree.Location = new System.Drawing.Point(-2, 0);
            this.paneltree.Name = "paneltree";
            this.paneltree.Size = new System.Drawing.Size(545, 450);
            this.paneltree.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndraw);
            this.Controls.Add(this.paneltree);
            this.Controls.Add(this.cbxcolor);
            this.Controls.Add(this.txtleftangle);
            this.Controls.Add(this.txtrightangle);
            this.Controls.Add(this.txtleftlen);
            this.Controls.Add(this.txtrightlen);
            this.Controls.Add(this.txtlength);
            this.Controls.Add(this.txtdeep);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblleftangle);
            this.Controls.Add(this.lblrightangle);
            this.Controls.Add(this.lblper2);
            this.Controls.Add(this.lblper1);
            this.Controls.Add(this.lbllength);
            this.Controls.Add(this.lbldeep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndraw;
        private System.Windows.Forms.Label lbldeep;
        private System.Windows.Forms.Label lbllength;
        private System.Windows.Forms.Label lblper1;
        private System.Windows.Forms.Label lblper2;
        private System.Windows.Forms.Label lblrightangle;
        private System.Windows.Forms.Label lblleftangle;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.TextBox txtdeep;
        private System.Windows.Forms.TextBox txtlength;
        private System.Windows.Forms.TextBox txtrightlen;
        private System.Windows.Forms.TextBox txtleftlen;
        private System.Windows.Forms.TextBox txtrightangle;
        private System.Windows.Forms.TextBox txtleftangle;
        private System.Windows.Forms.ComboBox cbxcolor;
        private System.Windows.Forms.Panel paneltree;
    }
}

