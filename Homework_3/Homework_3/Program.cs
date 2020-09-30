using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            //List<Order> list1 = new List<Order>();
            //List<OrderDetails> list2 = new List<OrderDetails>();
            Order or1 = new Order();
            bool judge = true;
            while(judge)
            {
                Console.WriteLine("请输入对应功能的数字：");
                Console.WriteLine("1.增加订单;2.删除订单;3.修改订单;4.查询订单;5.显示所有订单;6.对订单排序;7.序列化订单;8.反序列化订单;9.退出");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    //添加订单
                    case "1":
                        Console.WriteLine("请输入订单编号：");
                        String orderID = Convert.ToString(Console.ReadLine());
                        bool same = false;
                        foreach(Order item in service.list1)
                        {
                            if (item.OrderId == orderID)
                            {
                                Console.WriteLine("订单编号已经存在！");
                                same = true;
                            }
                        }
                        /*
                        if (list1.Exists(o => o.OrderId == orderID))
                        {
                            Console.WriteLine("新增订单与前面的订单重复，添加失败！");
                        }*/
                        if(!same)
                        {
                            Console.WriteLine("请输入商品名称：");
                            String productName = Console.ReadLine();
                            Console.WriteLine("请输入商品单价：");
                            double unitprice = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("请输入商品数量：");
                            int productNum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("请输入顾客姓名：");
                            String clientName = Console.ReadLine();
                            Console.WriteLine("请输入顾客电话 ：");
                            String clientPhone = Console.ReadLine();
                            Console.WriteLine("请输入顾客地址：");
                            String clientaddress = Console.ReadLine();
                            Console.WriteLine("请输入下单日期(yyyy-mm-dd)：");
                            DateTime date = Convert.ToDateTime(Console.ReadLine());
                            double totalPrice = productNum * unitprice;
                            Order order1 = new Order(orderID, productName, productNum,unitprice,totalPrice, clientName, clientPhone, clientaddress);
                            OrderDetails orderDetails1 = new OrderDetails(orderID, productName, productNum, clientName, unitprice, date, totalPrice);
                            if (order1.Equals(order1) && orderDetails1.Equals(orderDetails1))
                            {
                                service.AddOrder(order1, orderDetails1);
                                Console.WriteLine("订单添加成功！");
                            }
                            else Console.WriteLine("新增订单与前面的订单重复，添加失败！");
                        }
                        service.list1.ForEach(o => Console.WriteLine(o.ToString()));
                        break;
                    //删除对应编号订单
                    case "2":
                        Console.WriteLine("请输入订单编号：");
                        String id = Convert.ToString(Console.ReadLine());
                        service.RemoveOrder(id);
                        break;
                    //修改订单信息
                    case "3":
                        Console.WriteLine("请输入订单编号：");
                        String orderID1 = Convert.ToString(Console.ReadLine());
                        //判断是否存在该订单号
                        if (service.list1.Exists(o => o.OrderId == orderID1))
                        {//list1 != null && list1.Any(p => p.OrderId == orderID1
                            Console.WriteLine("请输入商品名称：");
                            String productName1 = Console.ReadLine();
                            Console.WriteLine("请输入商品单价：");
                            double unitprice1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("请输入商品数量：");
                            int productNum1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("请输入顾客姓名：");
                            String clientName1 = Console.ReadLine();
                            Console.WriteLine("请输入顾客电话 ：");
                            String clientPhone1 = Console.ReadLine();
                            Console.WriteLine("请输入顾客地址：");
                            String clientaddress1 = Console.ReadLine();
                            Console.WriteLine("请输入下单日期(yyyy-mm-dd)：");
                            DateTime date1 = Convert.ToDateTime(Console.ReadLine());
                            double totalPrice1 = productNum1 * unitprice1;
                            Order order2 = new Order(orderID1, productName1, productNum1,unitprice1,totalPrice1, clientName1, clientPhone1, clientaddress1);
                            OrderDetails orderDetails2 = new OrderDetails(orderID1, productName1, productNum1, clientName1, unitprice1, date1, totalPrice1);
                            service.UpdateOrder(order2, orderDetails2);
                        }
                        else Console.WriteLine("订单编号不存在！");
                        break;
                    //查询订单
                    case "4":
                        Console.WriteLine("请输入对应查询方式的数字：");
                        Console.WriteLine("1.指定金额范围内订单；2.指定顾客订单；3.指定产品订单；");
                        int num = Convert.ToInt32(Console.ReadLine());
                        service.SearchOrder(num);
                        break;
                    //显示所有订单
                    case "5":
                        service.list1.ForEach(o => Console.WriteLine(o));
                        break;
                    //对订单排序输出
                    case "6":
                        if(or1 != null)
                        {
                            service.Sort(or1);
                        }
                        foreach (Order item in service.list1) {
                            Console.WriteLine(item);
                        }
                        break;
                    //订单列表序列化 
                    case "7":
                        service.Export(); 
                        break;
                    //订单列表反序列化
                    case "8":
                        Console.WriteLine("反序列化结果 ：");
                        service.Import(); 
                        break;
                    //退出程序
                    case "9":
                        judge = false;
                        break;
                    //非法输入，无法执行任定义好的功能
                    default:
                        Console.WriteLine("输入错误,请重新输入！");
                        break;
                }
            }
            
        }
    }
}
