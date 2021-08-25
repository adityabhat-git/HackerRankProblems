using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Result
    {
        /*
         * Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
         * Format of time given - 12:01:00AM
         */
        public static string timeConversion(string s)
        {
            var ampm = s.Substring(8);
            var hourComponent = s.Substring(0, 2);
            var remComponent = s.Substring(2, 6);
            if (ampm == "AM" && hourComponent == "12")
            {
                hourComponent = "00";
            }
            else if (ampm == "PM")
            {
                var numerichrComponent = int.Parse(hourComponent);
                if (numerichrComponent != 12)
                    hourComponent = Convert.ToString(12 + numerichrComponent);
            }
            return hourComponent + remComponent;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = Result.timeConversion(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
