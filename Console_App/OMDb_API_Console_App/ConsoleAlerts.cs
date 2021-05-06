using System;

namespace OMDb_API_Console_App
{
    public class ConsoleAlerts
    {
        public static void ChangeStringColour(string message, ConsoleColor color)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException(message: $"'{nameof(message)}' cannot be null or whitespace.", paramName: nameof(message));
            }

            Console.ForegroundColor = color;
            Console.WriteLine(value: message);
            Console.ResetColor();
        }
    }
}