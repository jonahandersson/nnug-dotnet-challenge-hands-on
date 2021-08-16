using System;
using Humanizer;
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


            Console.WriteLine("Fibonacci with Dotnet Debugging!");
            int result = DoSomeFibonacci(5);
            Console.WriteLine(result);
            
            
        }

        static int DoSomeFibonacci(int n)
        {
            Debug.WriteLine($"Entering {nameof(DoSomeFibonacci)} method");
            Debug.WriteLine($"We are looking for the {n}th number");
            int n1 = 0;
            int n2 = 1;
            int sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
                Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
            }
            // If n2 is 5 continue, else break.
            Debug.Assert(n2 == 5, "The return value is not 5 and it should be.");
           
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
