using System;

namespace numbers_between_even
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberA = 6;
            int numberB = 15;
            int sum = 0;

            for (int i = numberA; i<= numberB; i++)
            {
                if (i % 2 == 1)
                {
                    sum++;
                }

            }
            Console.WriteLine(sum);
 


        }





















        
    }
}
