using System;
using System.Collections.Generic;

namespace TechnicalAssessment
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numOfCases = int.Parse(Console.ReadLine());

            //Loop for the number of cases user inputs
            for (int i = 0; i < numOfCases; i++)
            {
                string input = Console.ReadLine();
                string reversedWords = ReverseWords(input);
                Console.WriteLine($"Case {i + 1}: {reversedWords}");
            }
        }

        /// <summary>
        /// This method reverses the order of words in a space separated string.
        /// </summary>
        /// <param name="input">The input string containing space separated words.</param>
        /// <returns>The reversed string with words in reverse order.</returns>
        public static string ReverseWords(string input)
        {
            string[] words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }

}
