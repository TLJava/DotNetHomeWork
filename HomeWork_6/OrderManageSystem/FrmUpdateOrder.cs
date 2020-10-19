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
    public partial class FrmUpdateOrder : Form
    {
        FrmOrderManageSystem frmOrderManageSystem = new FrmOrderManageSystem();
        public FrmUpdateOrder()
        {
            InitializeComponent();
        }
        public FrmUpdateOrder(OrderService orderService)
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new OrderContext())
                {
                    var order = new Order
                    {
                        OrderId = this.txtOrderNum.Text,
                        ProductName = this.txtPName.Text,
                        ProductQuantity = Convert.ToInt32(this.txtPNum.Text),
                        UnitPrice = Convert.ToInt32(this.txtUnitPrice.Text),
                        ClientName = this.txtClientName.Text,
                        ClientPhone = this.txtCPhone.Text,
                        ClientAddress = this.txtCAddress.Text,
                        date = DateTime.Now.ToLocalTime()
                    };

                    db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("输入格式有误或订单编号不存在！");
            }
            frmOrderManageSystem.queryall(); 
        }
    }
}
