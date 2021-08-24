using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    class Result
    {
        /*
         * Staircase detail.
         * This is a staircase of size n=4 :
         *    #
         *   ##
         *  ###
         * ####
         * Its base and height are both equal to n. It is drawn using # symbol and spaces. The last line is not preceded by any spaces
         * Write a program that prints a staircase of size n.
        */
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var spaces = new String(' ',n-i); // to print the number of characters for n number of times
                var hashes = new String('#', i);
                Console.WriteLine(spaces + hashes);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            Result.staircase(n);
            Console.ReadKey();
        }
    }
}
