using System;
using System.Linq;

namespace Anexinet
{
    public class RecursiveOperations
    {
		/// <summary>
		/// Validates that the entered value is suitable for the binary conversion attempt
		/// </summary>
		public static void ValidateInputToBinary()
		{
			Console.WriteLine("Enter the floating number value to convert");
			var input = Console.ReadLine();
			double nonInteger;
			double.TryParse(input, out nonInteger);

			if (nonInteger > 0 && nonInteger < 1)
			{
				var binaryRepresentation = ToBinary(nonInteger, string.Empty);
				Console.WriteLine(binaryRepresentation);
				return;
			}
			Console.WriteLine("Invalid input entered, aborting");
		}

		/// <summary>
		/// Validates that the entered value is a valid digit and within the accepted range
		/// </summary>
		public static void ValidateNumberOfParenthesesCombination()
		{
			Console.WriteLine("Enter the number of combinations");
			var input = Console.ReadLine();

			if (input.All(c => char.IsDigit(c)))
			{
				int number = Convert.ToInt32(input);

				if (number > 10)
				{
					Console.WriteLine("The number of combinations is too big");
					return;
				}

				PrintParentheses(number, number, string.Empty);
				return;
			}

			Console.WriteLine("Invalid input, aborting");
		}

		/// <summary>
		/// Converts a given number to it's binary representation if it's at most 32 character length at most
		/// </summary>
		/// <param name="number">Number to be evaluated in order to get the next bit</param>
		/// <param name="binary">The binary string so far</param>
		/// <returns></returns>
		private static string ToBinary(double number, string binary)
		{
			if(binary.Length > 32)
			{
				return "ERROR";
			}
			if (number > 0)
			{
				var result = number * 2;

				if (result >= 1)
				{
					return ToBinary(result - 1, $"{binary}1");
				}

				return ToBinary(result, $"{binary}0");
			}
			return binary;
		}

		/// <summary>
		/// Prints all the possible combinations  of properly closed parentheses for the given number
		/// </summary>
		/// <param name="numberOfOpenening">Total of opening parentheses</param>
		/// <param name="numberOfClosing">Total of closing parentheses</param>
		/// <param name="parentheses">The string that contains the possible combinations that's being built so far</param>
		private static void PrintParentheses(int numberOfOpenening, int numberOfClosing, string parentheses)
		{
			if(numberOfOpenening == 0 && numberOfClosing == 0)
			{
				Console.WriteLine(parentheses);
			}

			if(numberOfOpenening > numberOfClosing)
			{
				return;
			}

			if (numberOfOpenening > 0)
			{
				PrintParentheses(numberOfOpenening - 1, numberOfClosing, $"{parentheses}(");
			}

			if (numberOfClosing > 0)
			{
				PrintParentheses(numberOfOpenening, numberOfClosing - 1, $"{parentheses})");
			}
		}
	}
}
