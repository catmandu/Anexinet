using System;
using System.Linq;
using System.Text;

namespace Anexinet
{
    public class ListsOperations
    {
        /// <summary>
        /// Prints the numbered list of a given list of words and distincts the odd-numbered ones
        /// </summary>
        public static void OddNumberedPositions()
        {
            Console.WriteLine("Enter a comma separated list of values to return only odd-numbered ones");
            var listOfWords = Console.ReadLine();
            Console.Clear();

            if (!string.IsNullOrEmpty(listOfWords))
            {
                var fullArray = listOfWords.Split(',');

                if(fullArray.Length == 1)
                {
                    Console.WriteLine("There was only 1 word: {0}", fullArray[0]);
                    return;
                }

                var oddPositions = new StringBuilder();

                for (int i = 0; i < fullArray.Length; i++)
                {
                    Console.WriteLine("Word {0}: {1}", i + 1, fullArray[i].Trim());
                    if ((i+1) % 2 != 0)
                    {
                        oddPositions.Append($"{fullArray[i].Trim()}, ");
                    }
                }
                Console.WriteLine("\nOdd-numbered words: {0}", oddPositions.Remove(oddPositions.Length - 2, 2));
                return;
            }

            Console.WriteLine("Your input was empty");
        }

        /// <summary>
        /// Prints a given list of words surrounded by a rectangular frame made of '*' characters
        /// </summary>
        public static void FormattedListOfWords()
        {
            Console.WriteLine("Enter a comma separated list of values to print them formatted in a frame");

            var listOfWords = Console.ReadLine().Split(',');

            Console.Clear();

            var squareLength = listOfWords.OrderByDescending(s => s.Length).First().Trim().Length;

            Console.WriteLine(new string('*', squareLength + 4));
            foreach (var word in listOfWords)
            {
                var rightMargin = squareLength - word.Trim().Length + 1;
                Console.WriteLine($"* {word.Trim()}{new string(' ', rightMargin)}*");
            }
            Console.WriteLine(new string('*', squareLength + 4));
        }
    }
}
