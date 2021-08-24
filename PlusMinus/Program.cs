using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Result
    {
        /*
         * Given an array of integers, calculate the ratios of its elements that are positive, negative and zero.
         * Print the decimal value of each fraction on a new line with 6 places after decimal
         * Example - arr[1,1,0,-1,-1]
         * There are n=5 elements, two positive, two negative and one zero.
         * Their ratios are 2/5 = 0.400000, 2/5=0.400000 and 1/5= 0.200000.
         * The result is printed as follows
         * 0.400000
         * 0.400000
         * 0.200000
         */

        public static void plusMinus(List<int> arr)
        {
            double plusSum = 0.000000;
            double plusRatio = 0.000000;
            double minusSum = 0.000000;
            double minusRatio = 0.000000;
            double zeroSum = 0.000000;
            double zeroRatio = 0.000000;
            int total = arr.Count;
            for (int i = 0; i < total; i++)
            {
                if (arr[i] > 0)
                    plusSum++;
                else if (arr[i] < 0)
                    minusSum++;
                else
                    zeroSum++;
            }
            plusRatio = Math.Round(Convert.ToDouble(plusSum / total), 6);
            minusRatio = Math.Round(Convert.ToDouble(minusSum / total), 6);
            zeroRatio = Math.Round(Convert.ToDouble(zeroSum / total), 6);
            Console.WriteLine(plusRatio);
            Console.WriteLine(minusRatio);
            Console.WriteLine(zeroRatio);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            Result.plusMinus(arr);
            Console.ReadKey();
        }
    }
}
