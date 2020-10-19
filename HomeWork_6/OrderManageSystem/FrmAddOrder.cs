using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManageSystem
{
    public partial class FrmAddOrder : Form
    {
        FrmOrderManageSystem frmOrderManage = new FrmOrderManageSystem();
        public FrmAddOrder()
        {
            InitializeComponent();
        }

        public FrmAddOrder(OrderService orderService)
        {
            InitializeComponent();
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            String orderID = this.txtOrderNum.Text;
            bool same = false;
            /*
            foreach (Order item in orderService.list1)
            {
                if (item.OrderId == orderID)
                {
                    MessageBox.Show("订单编号已经存在");
                    same = true;
                }
            }
            */
            try
            {
                if (!same)
                {/*
                    if (order1.Equals(order1) && orderDetails1.Equals(orderDetails1))
                    {
                        orderService.AddOrder(order1, orderDetails1);
                        MessageBox.Show("订单添加成功！");
                    }
                    else MessageBox.Show("订单与前面订单重复！");
                    */
                    using(var db = new OrderContext())
                    {
                        var order = new Order
                        {
                            OrderId = this.txtOrderNum.Text,
                            ProductName = this.txtPName.Text,
                            ProductQuantity = Convert.ToInt32(this.txtPnum.Text),
                            UnitPrice = Convert.ToDouble(this.txtUnitPrice.Text),
                            ClientName = this.txtCname.Text,
                            ClientPhone = this.txtCPhone.Text,
                            ClientAddress = this.txtCAddress.Text,
                            date = DateTime.Now.ToLocalTime()
                        };

                        db.Orders.Add(order);
                        db.SaveChanges();
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("输入格式有误！");
            }
            frmOrderManage.queryall();
            
            
        }
    }
}
