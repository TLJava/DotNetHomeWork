using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework_3;

namespace OrderManageSystem
{
    public partial class FrmRemoveOrder : Form
    {
        FrmOrderManageSystem frmOrderManageSystem = new FrmOrderManageSystem();
        OrderService orderService;
        public FrmRemoveOrder()
        {
            InitializeComponent();
        }
        public FrmRemoveOrder(OrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService; 
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                bool same = false;
                String orderId = this.txtOrderNum.Text;
                foreach (Order item in orderService.list1)
                {
                    if (item.OrderId == orderId)
                    {
                        same = true;
                    }
                }
                if (same)
                {
                    orderService.RemoveOrder(orderId);
                    //frmOrderManageSystem.orderGridView.DataSource = new BindingList<Order>(orderService.list1);
                }
                else MessageBox.Show("订单编号不存在！");
            }
            catch
            {
                MessageBox.Show("订单删除失败！");
            }
            frmOrderManageSystem.queryall();

            //frmOrderManageSystem.orderGridView.DataSource = orderService.list1;

        }
    }
}
