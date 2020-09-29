namespace OrderManageSystem
{
    partial class FrmOrderManageSystem
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAllOrders = new System.Windows.Forms.Button();
            this.btnClientOrders = new System.Windows.Forms.Button();
            this.btnProductOrder = new System.Windows.Forms.Button();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMaxTotalPricce = new System.Windows.Forms.TextBox();
            this.txtMinTotalPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-2, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(585, 453);
            this.textBox1.TabIndex = 0;
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.Location = new System.Drawing.Point(589, 34);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(94, 23);
            this.btnAllOrders.TabIndex = 1;
            this.btnAllOrders.Text = "导出所有订单";
            this.btnAllOrders.UseVisualStyleBackColor = true;
            // 
            // btnClientOrders
            // 
            this.btnClientOrders.Location = new System.Drawing.Point(590, 135);
            this.btnClientOrders.Name = "btnClientOrders";
            this.btnClientOrders.Size = new System.Drawing.Size(94, 23);
            this.btnClientOrders.TabIndex = 2;
            this.btnClientOrders.Text = "指定顾客订单";
            this.btnClientOrders.UseVisualStyleBackColor = true;
            // 
            // btnProductOrder
            // 
            this.btnProductOrder.Location = new System.Drawing.Point(590, 183);
            this.btnProductOrder.Name = "btnProductOrder";
            this.btnProductOrder.Size = new System.Drawing.Size(94, 23);
            this.btnProductOrder.TabIndex = 3;
            this.btnProductOrder.Text = "指定产品订单";
            this.btnProductOrder.UseVisualStyleBackColor = true;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(690, 137);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(110, 21);
            this.txtClientName.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(690, 183);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(110, 21);
            this.txtProductName.TabIndex = 5;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(590, 241);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(93, 23);
            this.btnAddOrder.TabIndex = 6;
            this.btnAddOrder.Text = "添加订单";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(590, 289);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(93, 23);
            this.btnUpdateOrder.TabIndex = 7;
            this.btnUpdateOrder.Text = "修改订单";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.Location = new System.Drawing.Point(590, 334);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(93, 23);
            this.btnRemoveOrder.TabIndex = 8;
            this.btnRemoveOrder.Text = "删除订单";
            this.btnRemoveOrder.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "指定范围订单";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtMaxTotalPricce
            // 
            this.txtMaxTotalPricce.Location = new System.Drawing.Point(690, 68);
            this.txtMaxTotalPricce.Name = "txtMaxTotalPricce";
            this.txtMaxTotalPricce.Size = new System.Drawing.Size(110, 21);
            this.txtMaxTotalPricce.TabIndex = 10;
            this.txtMaxTotalPricce.Text = "最高金额";
            // 
            // txtMinTotalPrice
            // 
            this.txtMinTotalPrice.Location = new System.Drawing.Point(690, 96);
            this.txtMinTotalPrice.Name = "txtMinTotalPrice";
            this.txtMinTotalPrice.Size = new System.Drawing.Size(110, 21);
            this.txtMinTotalPrice.TabIndex = 11;
            this.txtMinTotalPrice.Text = "最低金额";
            // 
            // FrmOrderManageSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMinTotalPrice);
            this.Controls.Add(this.txtMaxTotalPricce);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.btnProductOrder);
            this.Controls.Add(this.btnClientOrders);
            this.Controls.Add(this.btnAllOrders);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmOrderManageSystem";
            this.Text = "订单管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAllOrders;
        private System.Windows.Forms.Button btnClientOrders;
        private System.Windows.Forms.Button btnProductOrder;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMaxTotalPricce;
        private System.Windows.Forms.TextBox txtMinTotalPrice;
    }
}

