using System;

namespace ConsoleUI.Factory
{
    public class ConsoleFactory
    {
        public static void EndApplication()
        {
            Log("Press any key to continue...");
            Console.ReadKey();
        }

        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}