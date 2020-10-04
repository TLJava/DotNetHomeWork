using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndraw_Click(object sender, EventArgs e)
        {
            int deepN = Convert.ToInt32(this.txtdeep.Text);
            double leng = Convert.ToDouble(this.txtlength.Text);
            if (graphics == null) graphics = paneltree.CreateGraphics();
            graphics.Clear(Color.White);    //在每次绘制前清空panel
            DrawCayleyTree(deepN, 200, 310, leng, -Math.PI / 2);
        }

        private Graphics graphics;
        /*
        double th1 = 30 * Math.PI / 180;
        double th2 = 30 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        */
        void DrawCayleyTree(int n,double x0, double y0,double leng, double th)
        {
            
            double per1 = Convert.ToDouble(this.txtrightlen.Text);
            double per2 = Convert.ToDouble(this.txtleftlen.Text);
            double th1 = Convert.ToDouble(this.txtrightangle.Text) * Math.PI / 180;
            double th2 = Convert.ToDouble(this.txtleftangle.Text) * Math.PI / 180;

            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void DrawLine(double x0,double y0,double x1,double y1)
        {
            String color = this.cbxcolor.Text;
            switch(color){
                case "蓝色":
                    graphics.DrawLine(
                             Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "绿色":
                    graphics.DrawLine(
                             Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "红色":
                    graphics.DrawLine(
                             Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "黄色":
                    graphics.DrawLine(
                             Pens.Yellow, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "棕色":
                    graphics.DrawLine(
                             Pens.Brown, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                default:
                    graphics.DrawLine(
                             Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break; 
            }
            
        }
    }
}
