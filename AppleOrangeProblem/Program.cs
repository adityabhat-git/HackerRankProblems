using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleOrangeProblem
{
    class Result
    {

        /*
         * Complete the 'countApplesAndOranges' function below.
         *
         * The function accepts following parameters:
         *  1. INTEGER s
         *  2. INTEGER t
         *  3. INTEGER a
         *  4. INTEGER b
         *  5. INTEGER_ARRAY apples
         *  6. INTEGER_ARRAY oranges
         */

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesCount = 0;
            int orangesCount = 0;
            List<int>applesDistance = new List<int>();
            List<int> orangesDistance = new List<int>();
            foreach (var apple in apples)
                applesDistance.Add(apple + a);
            foreach (var orange in oranges)
                orangesDistance.Add(orange + b);

            foreach (var distance in applesDistance)
            {
                if (distance >= s && distance <= t)
                    applesCount++;
            }
            foreach (var distance in orangesDistance)
            {
                if (distance >= s && distance <= t)
                    orangesCount++;
            }

            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);
			Console.ReadKey();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
