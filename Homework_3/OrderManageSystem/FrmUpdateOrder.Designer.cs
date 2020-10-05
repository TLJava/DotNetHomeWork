namespace OrderManageSystem
{
    partial class FrmUpdateOrder
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblPNum = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.lblCAddress = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPNum = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.txtCAddress = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(294, 38);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(73, 72);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(53, 12);
            this.lblOrderNum.TabIndex = 1;
            this.lblOrderNum.Text = "订单编号";
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Location = new System.Drawing.Point(73, 124);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(53, 12);
            this.lblPName.TabIndex = 2;
            this.lblPName.Text = "产品名称";
            // 
            // lblPNum
            // 
            this.lblPNum.AutoSize = true;
            this.lblPNum.Location = new System.Drawing.Point(73, 170);
            this.lblPNum.Name = "lblPNum";
            this.lblPNum.Size = new System.Drawing.Size(53, 12);
            this.lblPNum.TabIndex = 3;
            this.lblPNum.Text = "产品数量";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(73, 212);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 12);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "产品单价";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(73, 252);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(53, 12);
            this.lblClientName.TabIndex = 5;
            this.lblClientName.Text = "客户姓名";
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Location = new System.Drawing.Point(73, 293);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(53, 12);
            this.lblCPhone.TabIndex = 6;
            this.lblCPhone.Text = "客户电话";
            // 
            // lblCAddress
            // 
            this.lblCAddress.AutoSize = true;
            this.lblCAddress.Location = new System.Drawing.Point(73, 332);
            this.lblCAddress.Name = "lblCAddress";
            this.lblCAddress.Size = new System.Drawing.Size(53, 12);
            this.lblCAddress.TabIndex = 7;
            this.lblCAddress.Text = "客户地址";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(152, 72);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(100, 21);
            this.txtOrderNum.TabIndex = 9;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(152, 121);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(100, 21);
            this.txtPName.TabIndex = 10;
            // 
            // txtPNum
            // 
            this.txtPNum.Location = new System.Drawing.Point(152, 167);
            this.txtPNum.Name = "txtPNum";
            this.txtPNum.Size = new System.Drawing.Size(100, 21);
            this.txtPNum.TabIndex = 11;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(152, 209);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 21);
            this.txtUnitPrice.TabIndex = 12;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(152, 249);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(100, 21);
            this.txtClientName.TabIndex = 13;
            // 
            // txtCPhone
            // 
            this.txtCPhone.Location = new System.Drawing.Point(152, 290);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(100, 21);
            this.txtCPhone.TabIndex = 14;
            // 
            // txtCAddress
            // 
            this.txtCAddress.Location = new System.Drawing.Point(152, 329);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(100, 21);
            this.txtCAddress.TabIndex = 15;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(73, 370);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(53, 12);
            this.lbldate.TabIndex = 16;
            this.lbldate.Text = "下单日期";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(152, 367);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 21);
            this.txtdate.TabIndex = 17;
            // 
            // FrmUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.txtCAddress);
            this.Controls.Add(this.txtCPhone);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtPNum);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtOrderNum);
            this.Controls.Add(this.lblCAddress);
            this.Controls.Add(this.lblCPhone);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblPNum);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.btnUpdate);
            this.Name = "FrmUpdateOrder";
            this.Text = "修改订单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblPNum;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.Label lblCAddress;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPNum;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.TextBox txtCAddress;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtdate;
    }
}