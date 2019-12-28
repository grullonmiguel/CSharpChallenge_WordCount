using ConsoleUI.Factory;

namespace ConsoleUI
{
    public class Program
    {
        private static void Main()
        {
            Process(DataFactory.GetSentences());

            ConsoleFactory.EndApplication();
        }

        /// <summary>
        /// First string (tests[0]) Values:
        /// Total Words: 14
        /// Total Characters: 89
        /// Character count(minus line returns and spaces): 60
        /// Most used word: the(2 times)
        /// Most used character: e(10 times)
        /// 
        /// Second string (tests[1]) Values:
        /// Total Words: 45
        /// Total Characters: 276
        /// Character count(minus line returns and spaces): 230
        /// Most used word: the(6 times)
        /// Most used character: t(24 times)
        /// </summary>
        private static void Process(string[] sentences)
        {
            foreach (var sentence in sentences)
            {
                DataProcessor.DisplayTotalWords(sentence);
                DataProcessor.DisplayTotalCharacters(sentence);
                DataProcessor.DisplayCharacterCount(sentence);
                DataProcessor.DisplayMostUsedWord(sentence);
                DataProcessor.DisplayMostUsedCharacters(sentence);
                ConsoleFactory.Log("");
            }
        }
    }
}