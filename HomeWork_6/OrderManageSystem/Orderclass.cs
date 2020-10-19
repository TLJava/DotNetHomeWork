using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OrderManageSystem
{
    public class OrderContext : DbContext
    {
        public OrderContext(): base("book")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());
        }
        /// <summary>
        /// 实体类表
        /// </summary>
        public DbSet<Order> Orders { get; set; }
    }

    [Table("OrderDB")]
    public class Order:IComparable
    {
        [Key]//标识主键
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)] //非自增式
        [MaxLength(4)]
        [Column(TypeName = "varchar")]
        public String OrderId { get; set; } 
        public String ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double UnitPrice { get; set; }
        public String ClientName { get; set; }
        public String ClientPhone { get; set; }
        public String ClientAddress { get; set; }
        public DateTime date { get; set; }
        private double totalPrice;
        public double TotalPrice {
            get { return totalPrice; }
            set { totalPrice = ProductQuantity * UnitPrice; }
        }
        public Order() { }
        //构建一个订单对象
        public Order(String Id,String pName,int pNum,double unitPrice,double tPrice,String cName,String cPhone,String caddress)
        {
            this.OrderId = Id;
            this.ProductName = pName;
            this.ProductQuantity = pNum;
            this.UnitPrice = unitPrice;
            this.totalPrice = tPrice;
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
                   ProductQuantity == order.ProductQuantity &&
                   ClientName == order.ClientName &&
                   ClientPhone == order.ClientPhone &&
                   ClientAddress == order.ClientAddress;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(OrderId);
        }

        OrderService service = new OrderService();

        //打印订单到控件中
        /*
        public override string ToString()
        {
            Console.WriteLine("订单号 产品名 数量 单价 总价 客户名  客户电话     地址");
            string str = $"{OrderId}   " + $"{ProductName}    " + $"{ProductQuantity}   " + $"{UnitPrice}  " 
                + $"{totalPrice}  "+ $"{ClientName}  " + $"{ClientPhone}  " + $"{ClientAddress}\n";
            return str;
        }*/
    }
}
