namespace OrderManageSystem
{
    partial class FrmRemoveOrder
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
            this.BtnRemove = new System.Windows.Forms.Button();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(225, 50);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 0;
            this.BtnRemove.Text = "删除";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(58, 79);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(100, 21);
            this.txtOrderNum.TabIndex = 1;
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(56, 50);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(53, 12);
            this.lblOrderNum.TabIndex = 2;
            this.lblOrderNum.Text = "订单编号";
            // 
            // FrmRemoveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 236);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.BtnRemove);
            this.Name = "FrmRemoveOrder";
            this.Text = "删除订单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.Label lblOrderNum;
    }
}