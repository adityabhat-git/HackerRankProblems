using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriplets
{
    class Result
    {

        /*
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int AliceScore = 0;
            int BobScore = 0;
            List<int> ScoreArray = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    AliceScore++;
                else if(a[i] < b[i])
                    BobScore++;
            }
            ScoreArray.Add(AliceScore);
            ScoreArray.Add(BobScore);
            return ScoreArray;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            List<int> result = Result.compareTriplets(a, b);
            Console.WriteLine(string.Join(" ",result));
            Console.ReadKey();
        }
    }
}
