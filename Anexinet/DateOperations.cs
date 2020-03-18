using System;
using System.Text.RegularExpressions;

namespace Anexinet
{
    public class DateOperations
    {
        public static void DateSubstraction()
        {
            Console.WriteLine("Enter 2 dates in the following format: YYYY-MM-DD\n");

            Console.Write("First date: ");
            var dateString1 = Console.ReadLine();

            Console.Write("Second date: ");
            var dateString2 = Console.ReadLine();

            if (Regex.IsMatch(dateString1, @"\d{4}-\d{2}-\d{2}") && Regex.IsMatch(dateString2, @"\d{4}-\d{2}-\d{2}"))
            {
                DateTime dateTime1;
                DateTime dateTime2;

                DateTime.TryParse(dateString1, out dateTime1);
                DateTime.TryParse(dateString2, out dateTime2);

                if (dateTime1 != default(DateTime) && dateTime2 != default(DateTime))
                {
                    var minutes = dateTime1 > dateTime2 ? dateTime1.Subtract(dateTime2).TotalMinutes : dateTime2.Subtract(dateTime1).TotalMinutes;
                    Console.WriteLine("Minutes between dates: {0}", minutes);
                    return;
                }

                Console.WriteLine("An invalid date was entered, aborting");
                return;
            }

            Console.WriteLine("An invalid date format was entered, aborting");
        }
    }
}
