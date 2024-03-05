using System;
using System.Runtime.ConstrainedExecution;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, ans = 0;
            char op;
            Console.WriteLine("Input the first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the operator:");
            op = (char)Console.Read();
            switch (op)
            {
                case '+': ans = a + b; break;
                case '-': ans = a - b; break;
                case '*': ans = a * b; break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Error!");
                    }
                    else
                    {
                        ans = a / b;
                    }
                    break;
            }
            Console.WriteLine($"The result is:{ans}");
        }
    }
}
