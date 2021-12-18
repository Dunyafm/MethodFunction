using System;

namespace numbers_between_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = 4;
            int numberB = 13;
            int count = 0;
            for (int i = numberA; i <numberB; i++)
            {
                if (i % 2 ==1)
                {
                    count++;
                }


            }
            Console.WriteLine(count);





















        }
    }
}
