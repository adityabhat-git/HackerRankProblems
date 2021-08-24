using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    public class Result
    {
        /*
         * Given a square matrix, calculate the absolute difference between the sums of its diagonals.
         * For example, the square matrix  is shown below:
         * 1 2 3
         * 4 5 6
         * 9 8 9
         * The left to right diagonal sum is = 1 + 5 + 9 = 15
         * The right to left diagonal sum is = 3 + 5 + 9 = 17
         * Their absolute difference is |15-17| = 2
        */
        public static int diagonalDifference(List<List<int>> arr)
        {
            int right = 0;
            int left = 0;
            int result = 0;
            int rowCount = arr.Count - 1;
            int listCount = arr[0].Count;
            for (int j = 0; j < listCount; j++)
            {
                right += arr[j][j];
                left += arr[rowCount - j][j];
            }
            result = Math.Abs(right - left);
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
