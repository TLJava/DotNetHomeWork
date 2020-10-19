using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OrderManageSystem
{
    public partial class FrmOrderManageSystem : Form
    {
        OrderService orderService = new OrderService();
        public FrmOrderManageSystem()
        {
            InitializeComponent();
        }
        private float X;
        private float Y;

        /// 将控件的宽，高，左边距，顶边距和字体大小暂存到tag属性中
        /// </summary>
        /// <param name="cons">递归控件中的控件</param>
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }

        //根据窗体大小调整控件大小
        private void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {

                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//获取控件的Tag属性值，并分割后存储字符串数组
                float a = System.Convert.ToSingle(mytag[0]) * newx;//根据窗体缩放比例确定控件的值，宽度
                con.Width = (int)a;//宽度
                a = System.Convert.ToSingle(mytag[1]) * newy;//高度
                con.Height = (int)(a);
                a = System.Convert.ToSingle(mytag[2]) * newx;//左边距离
                con.Left = (int)(a);
                a = System.Convert.ToSingle(mytag[3]) * newy;//上边缘距离
                con.Top = (int)(a);
                Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字体大小
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }
        }

        //查询所订单并输出
        public void queryall()
        {
            var query = from s in Order
                         where s.TotalPrice >= 0
                         orderby s.OrderId
                         select s;
            var lst1 = query.ToList();
            this.orderGridView.DataSource = null;
            this.orderGridView.DataSource = lst1;
            
        }

        //显示所有订单
        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            queryall();
        }
        //指定金额范围订单
        private void button1_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(this.txtMinTotalPrice.Text);
            int max = Convert.ToInt32(this.txtMaxTotalPricce.Text);
            /*
            var query1 = from s1 in orderService.list1
                         where s1.TotalPrice >= min & s1.TotalPrice <= max
                         orderby s1.TotalPrice
                         select s1;
            var lst1 = query1.ToList();
            this.orderGridView.DataSource = lst1;
            */
        }
        //指定顾客订单
        private void btnClientOrders_Click(object sender, EventArgs e)
        {
            string clientName = this.txtClientName.Text;
            /*
            var query2 = from s2 in orderService.list1
                         where s2.ClientName == clientName
                         orderby s2.TotalPrice
                         select s2;
            var lst2 = query2.ToList();
            this.orderGridView.DataSource = lst2;
            */
        }
        //指定产品订单
        private void btnProductOrder_Click(object sender, EventArgs e)
        {
            String pname = this.txtProductName.Text;
            /*
            var query3 = from s3 in orderService.list1
                         where s3.ProductName == pname
                         orderby s3.TotalPrice
                         select s3;
            var lst3 = query3.ToList();
            this.orderGridView.DataSource = lst3;
            */
        }
        //添加订单
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FrmAddOrder addOrder = new FrmAddOrder(orderService);
            addOrder.ShowDialog();
        }
        //修改订单
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            FrmUpdateOrder frmUpdateOrder = new FrmUpdateOrder(orderService);
            frmUpdateOrder.ShowDialog();
        }
        //删除订单
        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            FrmRemoveOrder frmRemoveOrder = new FrmRemoveOrder(orderService);
            frmRemoveOrder.ShowDialog();
        }

        //导入订单
        private void btnImportOrder_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("导入订单失败！");
            }
        }
        //导出订单
        private void btnExportOrder_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application myExcel = null;
            void print(DataGridView orderGridView)
            {
                //导出到execl   
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "导出Excel (*.xls)|*.xls";
                    saveFileDialog.FilterIndex = 0;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.CreatePrompt = true;
                    saveFileDialog.Title = "导出文件保存路径";
                    saveFileDialog.ShowDialog();
                    string strName = saveFileDialog.FileName;
                    if (strName.Length != 0)
                    {
                        //没有数据的话就不往下执行   
                        if (orderGridView.Rows.Count == 0)
                            return;

                        // toolStripProgressBar1.Visible = true;
                        System.Reflection.Missing miss = System.Reflection.Missing.Value;
                        //实例化一个Excel.Application对象
                        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                        excel.Application.Workbooks.Add(true);
                        excel.Visible = false;//若是true，则在导出的时候会显示EXcel界面。
                        if (excel == null)
                        {
                            MessageBox.Show("EXCEL无法启动！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Microsoft.Office.Interop.Excel.Workbooks books = (Microsoft.Office.Interop.Excel.Workbooks)excel.Workbooks;
                        Microsoft.Office.Interop.Excel.Workbook book = (Microsoft.Office.Interop.Excel.Workbook)(books.Add(miss));
                        Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                        sheet.Name = "test";
                        int m = 0, n = 0;
                        //生成Excel中列头名称   
                        for (int i = 0; i < orderGridView.Columns.Count; i++)
                        {
                            excel.Cells[1, i + 1] = orderGridView.Columns[i].HeaderText;//输出DataGridView列头名
                        }
                        //把DataGridView当前页的数据保存在Excel中   
                        for (int i = 0; i < orderGridView.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < orderGridView.Columns.Count; j++)
                            {
                                if (orderGridView[j, i].ValueType == typeof(string))
                                {
                                    excel.Cells[i + 2, j + 1] = "'" + orderGridView[j, i].Value.ToString();
                                }
                                else
                                {
                                    excel.Cells[i + 2, j + 1] = orderGridView[j, i].Value.ToString();
                                }
                            }
                        }
                        sheet.SaveAs(strName, miss, miss, miss, miss, miss, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, miss, miss, miss);
                        book.Close(false, miss, miss);
                        books.Close();
                        excel.Quit();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(sheet);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(book);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(books);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                        GC.Collect();
                        MessageBox.Show("数据已经成功导出!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // toolStripProgressBar1.Value = 0;
                        System.Diagnostics.Process.Start(strName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示");
                }
            }
        }

        //load事件，这两个事件是为了使控件和窗体的比例一起变化
        private void FrmOrderManageSystem_Load(object sender, EventArgs e)
        {
            X = this.Width;//获取窗体的宽度
            Y = this.Height; //获取窗体的高度
            setTag(this); //调用方法
        }
        //Resize事件
        private void FrmOrderManageSystem_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X; //窗体宽度缩放比例
            float newy = (this.Height) / Y;//窗体高度缩放比例
            setControls(newx, newy, this); //随窗体改变控件大小
        }
    }
}
