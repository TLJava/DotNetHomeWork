using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderManageSystem
{
    [Serializable]
    public class OrderService
    {   
        public void AddOrder(Order order1,OrderDetails orderde1)     //添加订单
        {
            try
            {
                   //往列表中添加订单
                   //往列表中添加新的订单明细
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
                
            }
            catch
            {
                Console.WriteLine("删除订单失败！");
            }
        }
        public void UpdateOrder(Order order,OrderDetails details) //更新对应编号的订单和订单明细
        {
            try
            {/*
                foreach(Order item in list1)
                {
                    if (item.OrderId == order.OrderId)
                    {
                        item.ProductName = order.ProductName;
                        item.ProductQuantity = order.ProductQuantity;
                        item.UnitPrice = order.UnitPrice;
                        item.TotalPrice = item.TotalPrice;
                        item.ClientName = order.ClientName;
                        item.ClientPhone = order.ClientPhone;
                        item.ClientAddress = order.ClientAddress;
                    }
                }
                */
            }
            catch
            {
                Console.WriteLine("更新订单失败！");
            }
        }
        public void SearchOrder(int i)  //查询订单
        {
            switch (i)
            {/*
                case 1:
                    Console.WriteLine("请输入查询的最小金额：");
                    int min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("请输入查询的最大金额：");
                    int max = Convert.ToInt32(Console.ReadLine());

                    var query1 = from s1 in list1
                                 where s1.TotalPrice >= min & s1.TotalPrice <= max
                                 orderby s1.TotalPrice
                                 select s1;
                    
                    break;
                case 2:
                    var query2 = from s2 in list1
                                 where s2.ClientName == clientName
                                 orderby s2.TotalPrice
                                 select s2;
                    
                    break;
                case 3:
                    
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
                    */
            }
        }

        public void Export()     //将所有订单序列化成xml文件(导入订单)
        {
            try
            {/*
                XmlSerializer xmls = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream("order.xml", FileMode.Create))
                {
                    xmls.Serialize(fs, this.list1);
                }
                Console.WriteLine("序列化完成！");
                */
            }
            catch
            {
                Console.WriteLine("订单序列化失败！");
            }
            
        }

        public void Import()    //导出订单
        {
            try
            {
                /*
                XmlSerializer xmls = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream("order.xml", FileMode.Open))
                {
                    List<Order> or = (List<Order>)xmls.Deserialize(fs);
                    foreach (Order item in or)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                */
            }
            catch
            {
                Console.WriteLine("订单反序列化失败！");
            }
        }
        public void Sort(Order order)   //对订单进行排序
        {
            //list1.Sort((o1, o2) => o1.OrderId.CompareTo(o2.OrderId));
        }
    }
}
