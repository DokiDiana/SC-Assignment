using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            // Task2
            const int MAXSIZE = 100;
            int[] arr1 = new int[MAXSIZE];
            int max = arr1[0], min = arr1[0], sum = 0;
            for (int i = 0; i < MAXSIZE; i++)
            {
                if (arr1[i] < min) { min = arr1[i]; }
                if (arr1[i] > max) { max = arr1[i]; }
                sum += arr1[i];
            }
            Console.WriteLine("The MAX of the array is: " + max);
            Console.WriteLine("The MIN of the array is: " + min);
            Console.WriteLine("The SUM of the array is: " + sum);
        }
    }
}
