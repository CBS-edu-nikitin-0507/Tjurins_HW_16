using System;

namespace Task2
{
    class Program
    {
        public static void FindHigest(int[] arr)
        {
            int higest = 0;
            foreach (dynamic val in arr)
            {
                if (val > higest) { higest = val; }
            }

            Console.WriteLine("Higest = " + higest);
        }

        public static void FindLowest(int[] arr)
        {
            int lowest = 101;
            foreach (dynamic val in arr)
            {
                if (val < lowest) { lowest = val; }
            }

            Console.WriteLine("Lowest = " + lowest);
        }

        public static void SumAndAvg(int[] arr) 
        {
            int sum = 0;
            float avg = 0;
            foreach(dynamic val in arr)
            {
                sum += val;
            }

            Console.WriteLine("Sum of all elements = "+sum);
            avg = sum / arr.Length;
            Console.WriteLine("Average = "+avg);
        }

        public static void NonZeroModNumbers(int[] arr)
        {
            Console.WriteLine("Odd numbers = ");
            foreach (dynamic val in arr)
            {
                if (val % 2 != 0){ Console.Write(val + " "); }
            }


        }

        static void Main(string[] args)
        {
            var rand = new Random();
            int[] arr = new int[15];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(101);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            FindHigest(arr);
            FindLowest(arr);
            SumAndAvg(arr);
            NonZeroModNumbers(arr);
        }
       
    }
}
