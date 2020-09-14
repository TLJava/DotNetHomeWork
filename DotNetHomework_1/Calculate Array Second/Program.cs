using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Array_Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请用空格作为间隔符输入所有数据：");
            string data = Console.ReadLine();
            string[] dataarr = data.Split(' ');
            int len = dataarr.GetLength(0);
            int[] numarr = new int[len];
            for (int i = 0; i < len; i++)
            {
                numarr[i] = Convert.ToInt32(dataarr[i]);
            }
            Most(numarr,dataarr);
            Console.WriteLine("数组中的所有数据的最大值是{0}", dataarr[0]);
            Console.WriteLine("数组中的所有数据的最小值是{0}", dataarr[1]);
            Console.WriteLine("数组中的所有数据的和是{0}", dataarr[2]);
            Console.WriteLine("数组中的所有数据的平均值是{0}", dataarr[3]);

            Console.ReadKey();
        }

        //求所有数据的和，最大值，最小值，平均值
        static void Most(int[] arr,string[] arr1)
        {
            int len1 = arr.GetLength(0);
            int max = arr[0];
            int min = arr[0];
            double average = 0;
            int sum = 0;
            for (int i = 0; i < len1; i++)
            {
                sum = sum + arr[i];
                if (arr[i] >= max) max = arr[i];
                if (arr[i] <= min) min = arr[i];
            }
            average = sum * 1.0 / len1;
            arr1[0] = Convert.ToString(max);
            arr1[1] = Convert.ToString(min);
            arr1[2] = Convert.ToString(sum);
            arr1[3] = Convert.ToString(average);
        }
    }
}
