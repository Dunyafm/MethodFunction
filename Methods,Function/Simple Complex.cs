using System;

namespace SimpleComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleComplex(144);
        }

        static void SimpleComplex(int n)
        {
            int count = 0;
            if (n <= 1)
            {
                Console.WriteLine("Correct number");
            }
            else
            {
                for (int i = 1; i <= 0; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }

                }
                if (count > 2)
                {
                    Console.WriteLine("Complex");
                }
                else
                {
                    Console.WriteLine("Simple");
                }








            }
















        }
    }
}

