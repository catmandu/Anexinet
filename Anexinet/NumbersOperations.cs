using System;
using System.Linq;
using System.Text;

namespace Anexinet
{
    public class NumbersOperations
    {
        public static void SecuenceNumbers()
        {
            Console.WriteLine("No luck here :(");
            Console.ReadKey();
        }
        /// <summary>
        /// Prints the roman numeral representation for a given integer number 
        /// </summary>
        public static void ToRomanNumeral()
        {
            Console.WriteLine("Please enter an integer number");

            var input = Console.ReadLine();

            if (input.All(c => char.IsDigit(c)))
            {
                var number = Convert.ToInt32(input);

                if (number < 3999)
                {
                    var romanNumeral = new StringBuilder();

                    var thousands = number / 1000;

                    romanNumeral.Append(new string('M', thousands));

                    var hundreds = number % 1000 / 100;
                    romanNumeral.Append(GetRomanCharacter(hundreds, "CD", "D", "CM", 'C'));

                    var tens = number % 1000 % 100 / 10;
                    romanNumeral.Append(GetRomanCharacter(tens, "XL", "L", "XC", 'X'));

                    var units = number % 1000 % 100 % 10;
                    romanNumeral.Append(GetRomanCharacter(units, "IV", "V", "IX", 'I'));

                    Console.WriteLine("The roman numeral for the value is: {0}", romanNumeral);
                    return;
                }
                
                Console.WriteLine("The number {0} exceeds the 3999 limit", number);
                return;
            }
            
            Console.WriteLine("Only number characters are allowed");
            return;
        }

        /// <summary>
        /// Returns the appropiate roman character from the ones provided
        /// </summary>
        /// <param name="number">Case number to compare with for the given scope</param>
        /// <param name="almostHalf">The almost half roman character representation for the given scope</param>
        /// <param name="half">The half roman character representation for the given scope</param>
        /// <param name="almostWhole">The almost whole roman character representation for the given scope</param>
        /// <param name="singleUnit">The single unit roman character representation for the given scope</param>
        /// <returns></returns>
        private static string GetRomanCharacter(int number, string almostHalf, string half, string almostWhole, char singleUnit)
        {
            switch (number)
            {
                case 4:
                    return almostHalf;
                case 5:
                    return half;
                case 9:
                    return almostWhole;
                default:
                    return new string(singleUnit, number);
            }
        }
    }
}
