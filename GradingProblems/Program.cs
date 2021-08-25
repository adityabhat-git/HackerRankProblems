using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingProblems
{
    class Result
    {

        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */

        public static List<int> gradingStudents(List<int> grades)
        {
            //Solution 1 long way
            //List<int> finalGrades = new List<int>();
            //int nextMultiple = 0;
            //foreach (int grade in grades)
            //{
            //    if (grade < 38)
            //        finalGrades.Add(grade);
            //    else
            //    {
            //        var quotient = grade / 5;
            //        var rem = grade % 5;
            //        if (rem > 0)
            //            nextMultiple = (quotient + 1) * 5;
            //        if (Math.Abs(grade - nextMultiple) < 3)
            //            finalGrades.Add(nextMultiple);
            //        else
            //            finalGrades.Add(grade);
            //    }
            //}
            //return finalGrades;

            //Solution 2 smart way
            for (int i = 0 ; i<grades.Count;i++)
            {
                var item = grades[i];
                if (item >= 38)
                {
                    var diff = 5 - (item % 5);
                    if (diff < 3)
                        grades[i] = item + diff;
                }
            }
            return grades;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> grades = new List<int>();
            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }
            List<int> result = Result.gradingStudents(grades);
            Console.WriteLine(String.Join("\n", result));
        }
    }
}
