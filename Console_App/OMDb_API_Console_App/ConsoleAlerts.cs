using System;

namespace OMDb_API_Console_App
{
    public class ConsoleAlerts
    {
        public void ChangeStringColour(string message, ConsoleColor color){
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}