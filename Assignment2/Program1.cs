namespace Assignment2
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            // Task1
            Console.WriteLine("Please input an number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    Console.WriteLine("All the prime factors of the number are: " + i + " " + num / i);
            }
        }
    }
}
