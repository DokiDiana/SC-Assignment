using System.Diagnostics.Tracing;
using System.Threading.Channels;

namespace Assignment4
{
    internal class Task2
    {
        class Clock
        {
            public event EventHandler Tick;
            public event EventHandler Alarm;

            public void OnTick()
            {
                Tick.Invoke(this, EventArgs.Empty);
            }

            public void OnAlarm()
            {
                Alarm.Invoke(this, EventArgs.Empty);
            }
        }
        static void Main(string[] args)
        {
            var Clk = new Clock();

            Clk.Tick += (sender, e) =>
            {
                Console.WriteLine("Tick tock");
            };
            Clk.Alarm += (sender, e) =>
            {
                Console.WriteLine("The clock is alarming");
            };
            for (int i = 0; i < 5; i++)
            {
                Clk.OnTick();
                System.Threading.Thread.Sleep(1000);
            }
            Clk.OnAlarm();
        }
    }
}
