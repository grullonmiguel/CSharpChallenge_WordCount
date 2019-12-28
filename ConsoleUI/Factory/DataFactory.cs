namespace ConsoleUI.Factory
{
    public class DataFactory
    {
        public static string[] GetSentences()
        {
            return new string[]
            {
            @"The test of the 
            best way to handle

multiple lines,   extra spaces and more.",
            @"Using the starter app, create code that will 
loop through the strings and identify the total 
character count, the number of characters
excluding whitespace (including line returns), and the
number of words in the string. Finally, list each word, ensuring it
is a valid word."
            };
        }       
    }
}