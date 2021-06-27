using System;

namespace Factorial_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(9));
        }

        static int factorial(int n)
        {
            int result = n;
            for(int i = 1; i < n; i++)
            {
                result = i * result;
                
            }
            return result;
        }
    }
}
