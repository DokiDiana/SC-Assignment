using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            // Task4
            bool isMatrix(int[,] arr)
            {
                int row = arr.GetLength(0);
                int col = arr.GetLength(1);
                int i = 0, j = 0;
                while (i == 0 && j < col - 1)
                {
                    if (arr[i, j] != arr[i + 1, j + 1]) { return false; }
                    j++;
                }
                i = 0; j = 0;
                while (i < row - 1 && j == 0)
                {
                    if (arr[i, j] != arr[i + 1, j + 1]) { return false; }
                    i++;
                }
                return true;
            }
            int[,] a = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            Console.WriteLine(isMatrix(a));
        }
    }
}
