using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            // Task3
            int[] arr2 = new int[101];
            bool isPrime(int num)
            {
                for (int i = 2; i < num; i++)
                {
                    if ((num % i) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            Console.WriteLine("All of the primes between 2 to 100 are: ");
            for (int i = 2; i < 101; i++)
            {
                arr2[i] = i;
                if (isPrime(arr2[i]))
                {
                    Console.Write(arr2[i] + " ");
                }
            }
        }
    }
}
