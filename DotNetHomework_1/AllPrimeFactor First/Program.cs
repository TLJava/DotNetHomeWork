using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrimeFactor_First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数据：");
            string data = Console.ReadLine();
            int number = Convert.ToInt32(data);
            int[] factorarr = new int[number];
            AllPrimeFactor(number, factorarr);
            Console.WriteLine("输入数据的所有质数因子为：");
            for (int i = 0; i < number; i++)
            {
                if (factorarr[i] >= 2) Console.WriteLine(factorarr[i]);
            }
            Console.ReadKey();
        }

        //找出输入数据的所有素数因子
        static void AllPrimeFactor(int data, int[] Factorarr)
        {
            int k = 0;
            //找出数据的所有大于1的因子并判断其是否为质数
            for (int i = 2; i <= data; i++)
            {
                if (data % i == 0)
                {
                    Factorarr[k] = i;
                    if (Factorarr[k] >= 2)
                    {
                        for (int t = 2; t <= Math.Sqrt(Factorarr[k]); t++)
                        {
                            if (Factorarr[k] % t == 0) Factorarr[k] = 0;
                        }
                    }
                    k++;
                }
            }
        }
    }
}
