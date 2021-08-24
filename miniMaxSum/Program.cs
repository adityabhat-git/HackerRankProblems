using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniMaxSum
{
    class Result
    {

        /*
         * Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
         * Then print the respective minimum and maximum values as a single line of two space-separated long integers.
         * Example arr = [1,3,5,7,9]
         * The minimum sum is 1+3+5+7=16 and maximum sum is 3+5+7+9=24.
         * The function prints
         * 16 24
        */

        public static void miniMaxSum(List<int> arr)
        {
            long minSum = 0;
            long maxSum = 0;
            List<long> SumCombinations = new List<long>();
            long totalSum = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                totalSum += arr[j];
            }
            for (int i = 0; i < arr.Count; i++)
            {
                SumCombinations.Add(totalSum - arr.ElementAt(i));
            }
            minSum = SumCombinations.Min();
            maxSum = SumCombinations.Max();
            Console.WriteLine(minSum + " " + maxSum);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
            Console.ReadKey();
        }
    }
}
