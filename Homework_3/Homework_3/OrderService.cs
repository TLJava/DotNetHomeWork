using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework_3
{
    [Serializable]
    class OrderService
    {
        public List<Order> list1= new List<Order>();  //存储订单
        public List<OrderDetails> list2 = new List<OrderDetails>();  //存储订单明细
        
        public void AddOrder(Order order1,OrderDetails orderde1)     //添加订单
        {
            try
            {
                list1.Add(order1);   //往列表中添加订单
                list2.Add(orderde1); //往列表中添加新的订单明细
            }
            catch
            {
                Console.WriteLine("订单添加失败！");
            }
        }
        public void RemoveOrder(String id)      //删除对应编号的订单和订单细节
        {
            int index1 = 0;
            int index2 = 0;

            try {
                foreach (Order item in list1)//删除订单列表中的订单
                {
                    if (item.OrderId == id) index1 = this.list1.IndexOf(item);
                    //list1.Remove(item);（首个匹配项）
                }
                foreach(OrderDetails item in list2)//删除订单明细列表中的订单信息
                {
                    if (item.OrderId == id) index2 = this.list2.IndexOf(item);
                     //list2.Remove(item);
                }
                this.list1.RemoveAt(index1);
                this.list2.RemoveAt(index2);
            }
            catch
            {
                Console.WriteLine("删除订单失败！");
            }
        }
        public void UpdateOrder(Order order,OrderDetails details) //更新对应编号的订单和订单明细
        {
            try
            {
                foreach(Order item in list1)
                {
                    if (item.OrderId == order.OrderId)
                    {
                        item.ProductName = order.ProductName;
                        item.ProductNumbers = order.ProductNumbers;
                        item.UnitPrice = order.UnitPrice;
                        item.TotalPrice = item.TotalPrice;
                        item.ClientName = order.ClientName;
                        item.ClientPhone = order.ClientPhone;
                        item.ClientAddress = order.ClientAddress;
                    }
                }
                foreach(OrderDetails item in list2)
                {
                    if(item.OrderId == details.OrderId)
                    {
                        item.ProductName = details.ProductName;
                        item.ProductNumbers = details.ProductNumbers;
                        item.UnitPrice = details.UnitPrice;
                        item.Date = details.Date;
                    }
                }
            }
            catch
            {
                Console.WriteLine("更新订单失败！");
            }
        }
        public void SearchOrder(int i)  //查询订单
        {
            switch (i)
            {
                case 1:
                    Console.WriteLine("请输入查询的最小金额：");
                    int min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("请输入查询的最大金额：");
                    int max = Convert.ToInt32(Console.ReadLine());

                    var query1 = from s1 in list1
                                 where s1.TotalPrice >= min & s1.TotalPrice <= max
                                 orderby s1.TotalPrice
                                 select s1;
                    List<Order> lst1 = query1.ToList();
                    lst1.ForEach(o => Console.WriteLine(o));
                    /*
                    foreach(Order item in lst1)
                    {
                        Console.WriteLine(item);
                    }*/
                    break;
                case 2:
                    Console.WriteLine("请输入顾客姓名：");
                    String clientName = Console.ReadLine();
                    var query2 = from s2 in list1
                                 where s2.ClientName == clientName
                                 orderby s2.TotalPrice
                                 select s2;
                    List<Order> lst2 = query2.ToList();
                    lst2.ForEach(o => Console.WriteLine(o));
                    /*
                    foreach(Order item in lst2)
                    {
                        Console.WriteLine(item);
                    }*/
                    //Console.Write(lst2);
                    break;
                case 3:
                    Console.WriteLine("请输入产品名称：");
                    String pname = Console.ReadLine();
                    var query3 = from s3 in list1
                                 where s3.ProductName == pname
                                 orderby s3.TotalPrice
                                 select s3;
                    List<Order> lst3 = query3.ToList();
                    foreach(Order item in lst3)
                    {
                        Console.WriteLine(item);
                    }
                    break;
            }
        }

        public void Export()     //将所有订单序列化成xml文件
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream("order.xml", FileMode.Create))
                {
                    xmls.Serialize(fs, this.list1);
                }
                Console.WriteLine("序列化完成！");
            }
            catch
            {
                Console.WriteLine("订单序列化失败！");
            }
            
        }

        public void Import()    //从xml文件中加载订单信息（反序列化）
        {
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream("order.xml", FileMode.Open))
                {
                    List<Order> or = (List<Order>)xmls.Deserialize(fs);
                    foreach (Order item in or)
                    {/*
                        Console.WriteLine("订单号 商品名称 商品数量 单价 总价 客户名 电话 地址");
                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", item.OrderId, item.ProductName,
                                item.ProductNumbers,item.UnitPrice,item.TotalPrice, item.ClientName, item.ClientPhone, item.ClientAddress);
                       */
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            catch
            {
                Console.WriteLine("订单反序列化失败！");
            }
        }
        public void Sort(Order order)   //对订单进行排序
        {
            list1.Sort((o1, o2) => o1.OrderId.CompareTo(o2.OrderId));
        }
    }
}
