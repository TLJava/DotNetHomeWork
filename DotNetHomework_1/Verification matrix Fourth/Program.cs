using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verification_matrix_Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入矩阵的行数：");
            string row = Console.ReadLine();

            int rows = Convert.ToInt32(row);
            Console.WriteLine("请输入矩阵的列数：");
            string column = Console.ReadLine();
            int columns = Convert.ToInt32(column);
            Console.WriteLine("请输入{0}*{1}的矩阵(用空格作为分隔符)：", rows,columns);
            
            string[][] strarr = new string[rows][];  //将每个数据作为一个单独的元素
            int[ ,] numarr = new int[rows,columns];  //读取二维矩阵
            for (int i = 0; i < rows; i++)
            {
                string datastr = Console.ReadLine();
                string[] tmp = datastr.Split(" ".ToCharArray());
                for (int j = 0; j < columns; j++)
                {
                    numarr[i,j] = int.Parse(tmp[j]);//将分割后的字符付给二维数组每个元素
                }
            }
            IsToplitAarr(numarr);
            if (IsToplitAarr(numarr)) Console.WriteLine("该矩阵是托普利茨矩阵!");
            else Console.WriteLine("该矩阵不是托普利茨矩阵!");
            Console.ReadKey();
        }

        //判断一个矩阵是否为托普利茨矩阵
        static Boolean IsToplitAarr(int[,] arr)
        {
            int rows = arr.GetLength(1);
            int cols = arr.GetLength(0);
            if (rows == 1 ||cols == 1) return true;

            for(int i=0;i<cols-1;i++)
            {
                for (int j=0;j<rows-1;j++)
                {
                    if (arr[i,j] != arr[i + 1,j + 1]) return false;
                }
            }
            return true;
        }
    }
}
