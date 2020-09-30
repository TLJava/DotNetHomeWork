using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class OrderDetails
    {
        private String orderId;
        private String productName;
        private int productNumbers;
        private String clientName;
        private double unitPrice;
        private DateTime date;
        private double totalPrice;
        public int ProductNumbers
        {
            get { return productNumbers; }
            set
            {
                if (value >= 0) productNumbers = value;
                else productNumbers = 0;
            }
        }
        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = productNumbers * unitPrice; }
        }
        public OrderDetails() { }
        public OrderDetails(String Id, String pName, int pNum, String cName, double unitPrice, DateTime date, double tprice)
        {
            this.orderId = Id;
            this.productName = pName;
            this.productNumbers = pNum;
            this.clientName = cName;
            this.unitPrice = unitPrice;
            this.date = date;
            this.TotalPrice = tprice;
        }

        public String OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
        public String ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public String ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public override bool Equals(object obj)  //检查订单是否重复 
        {
            var details = obj as OrderDetails;
            return details != null &&
                   productName == details.productName &&
                   productNumbers == details.productNumbers &&
                   unitPrice == details.unitPrice &&
                   clientName == details.clientName &&
                   date == details.date;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            Console.WriteLine("订单号 产品名 数量 单价 总价 客户名 下单日期");
            string str = $"{OrderId}  " + $"{ProductName}     " + $"{ProductNumbers}  " + $"{UnitPrice}  "
                + $"{totalPrice}  "+ $"{ClientName}  " + $"{date}\n" ;
            return str;
        }

    }    
}
