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
    public partial class FrmRemoveOrder : Form
    {
        FrmOrderManageSystem frmOrderManageSystem = new FrmOrderManageSystem();
        public FrmRemoveOrder()
        {
            InitializeComponent();
        }
        public FrmRemoveOrder(OrderService orderService)
        {
            InitializeComponent();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {//要判断数据库中是否存在该条数据
                using (var db = new OrderContext())
                {
                    var order = new Order
                    {
                        OrderId = this.txtOrderNum.Text
                    };
                    if (order != null)
                    {
                        db.Orders.Remove(order);
                        db.SaveChanges();
                    }
                    else MessageBox.Show("订单编号不存在！");
                } 
            }
            catch
            {
                MessageBox.Show("订单删除失败！");
            }
            frmOrderManageSystem.queryall();
        }
    }
}
