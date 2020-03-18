using System;

namespace Anexinet
{
    public class Menu
    {
        /// <summary>
        /// Prints the main menu for the application and handles the option selection
        /// </summary>
        public static void PrintMenu()
        {
            ConsoleKeyInfo option;
            do
            {
                Console.WriteLine("Choose an option from the menu\n");
                Console.WriteLine("1.- Enter 2 dates and obtain the difference between them in minutes");
                Console.WriteLine("2.- Add a comma separated list of values and show the ones in odd positions on the array");
                Console.WriteLine("3.- Add a comma separated list of words and format it as a message with frame");
                Console.WriteLine("4.- Print the binary representation of a floating point number (if it's at most 32 characters long)");
                Console.WriteLine("5.- Print the roman numeral representation of a given number (not greater than 3999)");
                Console.WriteLine("7.- Print the combinations of properly closed parenthesis for a given number (not greater than 10)");
                Console.WriteLine("ESC.- Exit the application");

                option = Console.ReadKey();

                Console.Clear();

                switch (option.Key)
                {
                    case ConsoleKey.D1:
                        DateOperations.DateSubstraction();
                        break;
                    case ConsoleKey.D2:
                        ListsOperations.OddNumberedPositions();
                        break;
                    case ConsoleKey.D3:
                        ListsOperations.FormattedListOfWords();
                        break;
                    case ConsoleKey.D4:
                        RecursiveOperations.ValidateInputToBinary();
                        break;
                    case ConsoleKey.D5:
                        NumbersOperations.ToRomanNumeral();
                        break;
                    case ConsoleKey.D6:
                        NumbersOperations.SecuenceNumbers();
                        break;
                    case ConsoleKey.D7:
                        RecursiveOperations.ValidateNumberOfParenthesesCombination();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Have a nice day :)");
                        break;
                    default:
                        Console.WriteLine("Option not recognized, please try again");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            } while (option.Key != ConsoleKey.Escape);
        }
    }
}
