using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//埃式筛法求从2到100之间的所有素数
namespace Ehrlich_Sieve_Third
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numarr = new int[101];
            for (int i = 2; i <= 100; i++)
            {
                numarr[i] = i;
            }
            FindPrimeNum(numarr);
            Console.WriteLine("从2到100的所有素数为：");
            for (int j = 2; j <= 100; j++)
            {
                if (numarr[j] != 0) Console.WriteLine(numarr[j]);
            }
            Console.ReadKey();
        }

        static void FindPrimeNum(int[] range)
        {//从完前往后遍历，将遇到的最小素数的倍数置为0（本身除外）
            int len = range.GetLength(0);
            for (int i = 0; i < len; i++)
            {//跳过已经被置为0的元素
                if (range[i] != 0)
                {//内层循环执行完一次某个数的倍数置0之后退到外层循环
                    for (int j = 2; (i * j) <= len; j++)
                    {
                        range[i * j] = 0;
                    }
                }
            }
        }
    }
}
