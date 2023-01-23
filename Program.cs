using System;

namespace _23012023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int M = Convert.ToInt32(Console.ReadLine());
            //int N = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;

            //while (M < N)
            //{
            //    sum += M;

            //    M++;
            //}

            //Console.WriteLine(sum);


            //N = Convert.ToInt32(Console.ReadLine());

            //int count = 0;

            ////while (N>=1)
            ////{
            ////    if (N % 15 == 0)
            ////    {
            ////        count++;
            ////    }

            ////    N--;
            ////}

            //bool hasWantedNumber = false;
            
            //for (int i=1; i < N; i++)
            //{
            //    if (i % 15 != 0)
            //    {
            //        continue;
            //    }

            //    hasWantedNumber = true;
            //    break;
            //}


            //if (hasWantedNumber==true)
            //{
            //    Console.WriteLine("var");
            //}
            //else
            //{
            //    Console.WriteLine("yox");
            //}


            int price = 50;
            int[] prices = { 35, 13, 34, 56, 10, 15, 50, 3 };
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine(prices[i]);
            }

            int[] numbers = { 34, 12, -10, 43, 56 };
            var index = 0;
            while (index < numbers.Length)
            {
                Console.WriteLine(numbers[index]);

                index++;
            }


            string[] names = { "Hikmet", "Tofiq", "Nermin", "Abbas" };


            for (int i = names.Length-1; i >=0; i--)
            {
                Console.WriteLine(names[i]);
            }


            int[] nums = { 23,124,-44,67};


            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine(sum);

          

        }
    }
}
