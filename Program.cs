using System;
using Humanizer;
using System;
using System.Diagnostics;


namespace DotNetDependencies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantities:");
            HumanizeQuantities();

            Console.WriteLine("\nDate/Time Manipulation:");
            HumanizeDates();

            Console.WriteLine("Fibonacci!");
            int result = DoSomeFibonacci(5);
            Console.WriteLine(result);
            
            
        }

        static int DoSomeFibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }
            return n == 0 ? n1 : n2;
        }

        static void HumanizeQuantities()
        {
            Console.WriteLine("case".ToQuantity(0));
            Console.WriteLine("case".ToQuantity(1));
            Console.WriteLine("case".ToQuantity(5));
        }

        static void HumanizeDates()
        {
            Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize());
        }
    }
}
