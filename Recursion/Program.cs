using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static int fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return fibonacci(n - 1) + fibonacci(n - 2);
        }
        static int factorial(int n)
        {
            if (n == 1)
                return n;
            else
                return n * factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"fibonacci: {fibonacci(8)}");
            Console.WriteLine($"factorial: {factorial(4)}");
        }
    }
}
