using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleUI.Factory
{
    /* 
        First string (tests[0]) Values:
        Total Words: 14
        Total Characters: 89
        Character count (minus line returns and spaces): 60
        Most used word: the (2 times)
        Most used character: e (10 times)

        Second string (tests[1]) Values:
        Total Words: 45
        Total Characters: 276
        Character count (minus line returns and spaces): 230
        Most used word: the (6 times)
        Most used character: t (24 times)
    */
    public static class DataProcessor
    {
        public static void DisplayTotalWords(string sentence)
        {            
            var words = sentence.RemoveExtraSpaces().Split(' ');

            ConsoleFactory.Log($"Total Words: {words.Length}");
        }

        public static void DisplayTotalCharacters(string sentence)
        {
            var chars = sentence.RemoveBreakReturns();

            ConsoleFactory.Log($"Total Characters: {chars.Length}");
        }

        public static void DisplayCharacterCount(string sentence)
        {
            var chars = sentence.StripAll();

            ConsoleFactory.Log($"Character count (minus line returns and spaces): {chars.Length}");
        }

        public static void DisplayMostUsedWord(string sentence)
        {
            var words = sentence.RemoveExtraSpaces().RemoveBreakReturns();

            var mostUsed = GetMostUsedWord(words).Key;

            var mostUsedCount = GetMostUsedWord(words).Count();

            ConsoleFactory.Log($"Most used word: {mostUsed} ({mostUsedCount} times)");
        }

        public static void DisplayMostUsedCharacters(string sentence)
        {
            var chars = sentence.StripAll();
            
            var mostUsed = GetMostUsedChar(chars).Key;

            var mostUsedCount = GetMostUsedChar(chars).Count();

            ConsoleFactory.Log($"Most used character: {mostUsed} ({mostUsedCount} times)");
        }

        #region Private Methods

        private static IGrouping<char, char> GetMostUsedChar(string input)
        {
            return input.GroupBy(x => x).OrderByDescending(x => x.Count()).First();
        }

        private static IGrouping<string, string> GetMostUsedWord(string input)
        {
            return Regex.Split(input.ToLower(), @"\W+").GroupBy(x => x).OrderByDescending(x => x.Count()).First();
        }

        #endregion

        #region Extension Methods

        private static string RemoveBreakReturns(this string input)
        {
            return input.Replace(Environment.NewLine, " ");
        }

        private static string RemoveExtraSpaces(this string input)
        {
            return Regex.Replace(input, @"\s+", " ");
        }

        private static string StripAll(this string input)
        {
            return input.RemoveExtraSpaces().RemoveBreakReturns().Replace(" ", "");
        }

        #endregion
    }
}