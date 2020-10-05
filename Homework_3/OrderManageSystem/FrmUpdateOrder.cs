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
    public partial class FrmUpdateOrder : Form
    {
        FrmOrderManageSystem frmOrderManageSystem = new FrmOrderManageSystem();
        OrderService orderService;
        public FrmUpdateOrder()
        {
            InitializeComponent();
        }
        public FrmUpdateOrder(OrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String orderID = this.txtOrderNum.Text;
            if (orderService.list1.Exists(o => o.OrderId == orderID))
            {
                try
                {
                    String pname = this.txtPName.Text;
                    int pnum = Convert.ToInt32(this.txtPNum.Text);
                    double unitprice = Convert.ToInt32(this.txtUnitPrice.Text);
                    String cname = this.txtClientName.Text;
                    String cphone = this.txtCPhone.Text;
                    String caddress = this.txtCAddress.Text;
                    DateTime date1 = Convert.ToDateTime(this.txtdate.Text);
                    double totalPrice = pnum * unitprice;
                    Order order2 = new Order(orderID, pname, pnum, unitprice, totalPrice, cname, cphone, caddress);
                    OrderDetails orderDetails2 = new OrderDetails(orderID, pname, pnum, cname, unitprice, date1, totalPrice);
                    orderService.UpdateOrder(order2, orderDetails2);

                    //frmOrderManageSystem.orderGridView.DataSource = orderService.list1;
                    MessageBox.Show("订单修改成功！");
                }
                catch
                {
                    MessageBox.Show("输入格式有误！");
                }
            }
            else MessageBox.Show("订单编号不存在！");
            frmOrderManageSystem.queryall(); 
        }
    }
}
