using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string month;
            string season;
            int day;

            Console.WriteLine("Input the month: ");
            month = Console.ReadLine().ToLower();

            Console.WriteLine("Input the day: ");
            day = Convert.ToInt32(Console.ReadLine());

            if (month == "january" || month == "february"
                || month == "march" || month == "december")
            {
                season = "summer";
            }

            else if (month == "june" || month == "april"
                || month == "march" || month == "may")
            {
                season = "autumn";
            }

            else if (month == "june" || month == "july"
                || month == "august" || month == "september")
            {
                season = "winter";
            }

            else
            {
                season = "spring";
            }

            if (month == "march" && day > 20)
            {
                season = "autumn";
            }

            else if (month == "june" && day > 20)
            {
                season = "winter";
            }

            else if (month == "september" && day > 20)
            {
                season = "spring";
            }

            else if (month == "december" && day > 20)
            {
                season = "summer";
            }
            Console.WriteLine("The season is: " + season);
            Console.ReadLine();
        }
    }
}
