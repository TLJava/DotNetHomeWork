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
            this.components = new System.ComponentModel.Container();
            this.btnAllOrders = new System.Windows.Forms.Button();
            this.btnClientOrders = new System.Windows.Forms.Button();
            this.btnProductOrder = new System.Windows.Forms.Button();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.bunMoneyRange = new System.Windows.Forms.Button();
            this.txtMaxTotalPricce = new System.Windows.Forms.TextBox();
            this.txtMinTotalPrice = new System.Windows.Forms.TextBox();
            this.btnImportOrder = new System.Windows.Forms.Button();
            this.btnExportOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllOrders.Location = new System.Drawing.Point(-1, 12);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(106, 23);
            this.btnAllOrders.TabIndex = 1;
            this.btnAllOrders.Text = "所有订单";
            this.btnAllOrders.UseVisualStyleBackColor = true;
            this.btnAllOrders.Click += new System.EventHandler(this.btnAllOrders_Click);
            // 
            // btnClientOrders
            // 
            this.btnClientOrders.Location = new System.Drawing.Point(0, 43);
            this.btnClientOrders.Name = "btnClientOrders";
            this.btnClientOrders.Size = new System.Drawing.Size(105, 23);
            this.btnClientOrders.TabIndex = 2;
            this.btnClientOrders.Text = "指定顾客订单";
            this.btnClientOrders.UseVisualStyleBackColor = true;
            this.btnClientOrders.Click += new System.EventHandler(this.btnClientOrders_Click);
            // 
            // btnProductOrder
            // 
            this.btnProductOrder.Location = new System.Drawing.Point(230, 43);
            this.btnProductOrder.Name = "btnProductOrder";
            this.btnProductOrder.Size = new System.Drawing.Size(106, 23);
            this.btnProductOrder.TabIndex = 3;
            this.btnProductOrder.Text = "指定产品订单";
            this.btnProductOrder.UseVisualStyleBackColor = true;
            this.btnProductOrder.Click += new System.EventHandler(this.btnProductOrder_Click);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(117, 45);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(106, 21);
            this.txtClientName.TabIndex = 4;
            this.txtClientName.Text = "顾客姓名";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(342, 45);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(105, 21);
            this.txtProductName.TabIndex = 5;
            this.txtProductName.Text = "产品名称";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(117, 12);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(106, 23);
            this.btnAddOrder.TabIndex = 6;
            this.btnAddOrder.Text = "添加订单";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateOrder.Location = new System.Drawing.Point(341, 12);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateOrder.TabIndex = 7;
            this.btnUpdateOrder.Text = "修改订单";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.Location = new System.Drawing.Point(230, 12);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(105, 23);
            this.btnRemoveOrder.TabIndex = 8;
            this.btnRemoveOrder.Text = "删除订单";
            this.btnRemoveOrder.UseVisualStyleBackColor = true;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // bunMoneyRange
            // 
            this.bunMoneyRange.Location = new System.Drawing.Point(453, 43);
            this.bunMoneyRange.Name = "bunMoneyRange";
            this.bunMoneyRange.Size = new System.Drawing.Size(105, 23);
            this.bunMoneyRange.TabIndex = 9;
            this.bunMoneyRange.Text = "指定范围订单";
            this.bunMoneyRange.UseVisualStyleBackColor = true;
            this.bunMoneyRange.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMaxTotalPricce
            // 
            this.txtMaxTotalPricce.Location = new System.Drawing.Point(694, 46);
            this.txtMaxTotalPricce.Name = "txtMaxTotalPricce";
            this.txtMaxTotalPricce.Size = new System.Drawing.Size(99, 21);
            this.txtMaxTotalPricce.TabIndex = 10;
            this.txtMaxTotalPricce.Text = "最高金额";
            // 
            // txtMinTotalPrice
            // 
            this.txtMinTotalPrice.Location = new System.Drawing.Point(564, 45);
            this.txtMinTotalPrice.Name = "txtMinTotalPrice";
            this.txtMinTotalPrice.Size = new System.Drawing.Size(104, 21);
            this.txtMinTotalPrice.TabIndex = 11;
            this.txtMinTotalPrice.Text = "最低金额";
            // 
            // btnImportOrder
            // 
            this.btnImportOrder.Location = new System.Drawing.Point(453, 12);
            this.btnImportOrder.Name = "btnImportOrder";
            this.btnImportOrder.Size = new System.Drawing.Size(105, 23);
            this.btnImportOrder.TabIndex = 12;
            this.btnImportOrder.Text = "导入订单";
            this.btnImportOrder.UseVisualStyleBackColor = true;
            this.btnImportOrder.Click += new System.EventHandler(this.btnImportOrder_Click);
            // 
            // btnExportOrder
            // 
            this.btnExportOrder.Location = new System.Drawing.Point(564, 12);
            this.btnExportOrder.Name = "btnExportOrder";
            this.btnExportOrder.Size = new System.Drawing.Size(104, 23);
            this.btnExportOrder.TabIndex = 13;
            this.btnExportOrder.Text = "导出订单";
            this.btnExportOrder.UseVisualStyleBackColor = true;
            this.btnExportOrder.Click += new System.EventHandler(this.btnExportOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAllOrders);
            this.groupBox1.Controls.Add(this.btnUpdateOrder);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtMinTotalPrice);
            this.groupBox1.Controls.Add(this.txtClientName);
            this.groupBox1.Controls.Add(this.btnExportOrder);
            this.groupBox1.Controls.Add(this.txtMaxTotalPricce);
            this.groupBox1.Controls.Add(this.bunMoneyRange);
            this.groupBox1.Controls.Add(this.btnImportOrder);
            this.groupBox1.Controls.Add(this.btnClientOrders);
            this.groupBox1.Controls.Add(this.btnProductOrder);
            this.groupBox1.Controls.Add(this.btnAddOrder);
            this.groupBox1.Controls.Add(this.btnRemoveOrder);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 75);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(674, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "-";
            // 
            // orderGridView
            // 
            this.orderGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(0, 112);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowTemplate.Height = 23;
            this.orderGridView.Size = new System.Drawing.Size(800, 338);
            this.orderGridView.TabIndex = 15;
            // 
            // FrmOrderManageSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOrderManageSystem";
            this.Text = "订单管理系统";
            this.Load += new System.EventHandler(this.FrmOrderManageSystem_Load);
            this.Resize += new System.EventHandler(this.FrmOrderManageSystem_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAllOrders;
        private System.Windows.Forms.Button btnClientOrders;
        private System.Windows.Forms.Button btnProductOrder;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Button bunMoneyRange;
        private System.Windows.Forms.TextBox txtMaxTotalPricce;
        private System.Windows.Forms.TextBox txtMinTotalPrice;
        private System.Windows.Forms.Button btnImportOrder;
        private System.Windows.Forms.Button btnExportOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView orderGridView;
        public System.Windows.Forms.BindingSource orderBindingSource;
    }
}

