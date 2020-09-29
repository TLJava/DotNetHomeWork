using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    public class Order:IComparable
    {
        //private int orderNumber;
        public int OrderId { get; set; } 
        public String ProductName { get; set; }
        public int ProductNumbers { get; set; }
        public double UnitPrice { get; set; }
        public String ClientName { get; set; }
        public String ClientPhone { get; set; }
        public String ClientAddress { get; set; }
        private double totalPrice;
        public double TotalPrice {
            get { return totalPrice; }
            set { totalPrice = ProductNumbers * UnitPrice; }
        }
        public Order() { }

        public Order(int Id,String pName,int pNum,String cName,String cPhone,String caddress)
        {
            this.OrderId = Id;
            this.ProductName = pName;
            this.ProductNumbers = pNum;
            this.ClientName = cName;
            this.ClientPhone = cPhone;
            this.ClientAddress = caddress;
        }
        public int CompareTo(Object obj)
        {
            Order a = obj as Order;
            return this.OrderId.CompareTo(a.OrderId);
        }

        //检查订单是否重复
        public override bool Equals(object obj)  
        {//如果列表为空或者其中一项不相等，则返回false，若不为空并且所有项都相等，则返回true
            var order = obj as Order;
            return order != null &&
                   ProductName == order.ProductName &&
                   ProductNumbers == order.ProductNumbers &&
                   ClientName == order.ClientName &&
                   ClientPhone == order.ClientPhone &&
                   ClientAddress == order.ClientAddress;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(OrderId);
        }

        OrderService service = new OrderService();

        //打印订单
        public override string ToString()
        {/*
            Console.WriteLine("订单号 产品名 数量 单价 总价 客户名 客户电话 地址");
            
            foreach(Order o in service.list1)
            {
                Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",o.OrderId,o.ProductName,
                        o.ProductNumbers,o.UnitPrice,o.TotalPrice,o.ClientName,o.ClientPhone,o.ClientAddress);
            }
           */ 
            return base.ToString();
        }
    }
}
