using System.Diagnostics.Tracing;
using System.Threading.Channels;

namespace Assignment4
{
    internal class Task1
    {
        delegate int Func(List<int> x);
        static void Main(string[] args)
        {
            List<int> num = new List<int>()
            {
                5, 7, 8, 1, 9, 3, 6
            };

            num.ForEach(s => Console.Write(s + " "));
            Console.WriteLine();
            int sum = 0;
            num.ForEach(s => sum += s);
            Console.WriteLine("The sum of the list is " + sum);
            Func Max = s =>
            {
                int max = num[0];
                for (int i = 1; i < s.Count; i++)
                {
                    if (s[i] > max)
                        max = s[i];
                }
                return max;
            };
            Func Min = s =>
            {
                int min = num[0];
                for (int i = 1; i < s.Count; i++)
                {
                    if (s[i] < min)
                        min = s[i];
                }
                return min;
            };
            Console.WriteLine("The max number of the list is " + Max(num));
            Console.WriteLine("The min number of the list is " + Min(num));

        }
    }
}
