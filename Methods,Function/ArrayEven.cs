using System;

namespace ArrayEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8 };
            EvenSum(arr);

        }
        static void EvenSum( int [] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];

                }


            }
            Console.WriteLine(sum);


















        }




















        
    }
}
