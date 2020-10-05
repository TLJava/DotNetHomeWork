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
    public partial class FrmAddOrder : Form
    {
        FrmOrderManageSystem frmOrderManage = new FrmOrderManageSystem();
        OrderService orderService;
        public FrmAddOrder()
        {
            InitializeComponent();
        }

        public FrmAddOrder(OrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            String orderID = this.txtOrderNum.Text;
            bool same = false;
            foreach (Order item in orderService.list1)
            {
                if (item.OrderId == orderID)
                {
                    MessageBox.Show("订单编号已经存在");
                    same = true;
                }
            }
            try
            {
                if (!same)
                {
                    String productName = this.txtPName.Text;
                    int productNum = Convert.ToInt32(this.txtPnum.Text);
                    double unitprice = Convert.ToDouble(this.txtUnitPrice.Text);
                    String clientName = this.txtCname.Text;
                    String clientPhone = this.txtCPhone.Text;
                    String clientaddress = this.txtCAddress.Text;
                    DateTime date = Convert.ToDateTime(this.txtdate.Text);
                    double totalPrice = productNum * unitprice;
                    var order1 = new Order(orderID, productName, productNum, unitprice, totalPrice, clientName, clientPhone, clientaddress);
                    OrderDetails orderDetails1 = new OrderDetails(orderID, productName, productNum, clientName, unitprice, date, totalPrice);

                    if (order1.Equals(order1) && orderDetails1.Equals(orderDetails1))
                    {
                        orderService.AddOrder(order1, orderDetails1);
                        MessageBox.Show("订单添加成功！");
                        //frmOrderManage.orderBindingSource.DataSource = new List<Order>(service.list1);
                    }
                    else MessageBox.Show("订单与前面订单重复！");
                }
            }
            catch
            {
                MessageBox.Show("输入格式有误！");
            }
            frmOrderManage.queryall();
            //frmOrderManage.orderGridView.DataSource = new List<Order>();
            
        }
    }
}
