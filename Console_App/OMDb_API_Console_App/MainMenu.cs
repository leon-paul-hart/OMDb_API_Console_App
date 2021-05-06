using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OMDb_API_Console_App
{
    class MainMenu
    {
        private static readonly HttpClient client = new();

        static async Task Main(string[] args)
        {
            DisplayIntroduction();

            string APIKey = GetAPIKey(APIKey: args.ToString());

            using (client)
            {
                await ApiQuery(APIKey: APIKey);
            }
        }

        private static void DisplayIntroduction()
        {
            Console.Clear();
            ConsoleAlerts.ChangeStringColour(message: "Welcome to the (Unofficial) OMDb (Open Movie Database) API Explorer Console App", color: ConsoleColor.Green);
            ConsoleAlerts.ChangeStringColour(message: "To use this application you will need a valid API key", color: ConsoleColor.Green);
            ConsoleAlerts.ChangeStringColour(message: $"You can register for an API key for free at https://www.omdbapi.com/apikey.aspx{Environment.NewLine}", color: ConsoleColor.Green);
        }

        private static string GetAPIKey(string APIKey)
        {
            if (string.IsNullOrWhiteSpace(APIKey))
            {
                throw new ArgumentException($"'{nameof(APIKey)}' cannot be null or whitespace.", nameof(APIKey));
            }

            if (APIKey.Length == 8)
            {
                ConsoleAlerts.ChangeStringColour(message: "You are using the API key : " + APIKey, color: ConsoleColor.Green);
                return APIKey;
            }
            else
            {
                while (APIKey.Length != 8)
                {
                    ConsoleAlerts.ChangeStringColour(message: "Please enter a valid OMDb API key", color: ConsoleColor.Yellow);
                    APIKey = Console.ReadLine();
                }
                return APIKey;
            }
        }

        private static async Task ApiQuery(string APIKey)
        {
            if (string.IsNullOrWhiteSpace(APIKey))
            {
                throw new ArgumentException($"'{nameof(APIKey)}' cannot be null or whitespace.", nameof(APIKey));
            }

            try
            {
                using Task<string> stringTask = client.GetStringAsync(requestUri: $"{Environment.NewLine}https://www.omdbapi.com/?s=princess&apikey={APIKey}");

                string msg = await stringTask;

                Console.Clear();

                Console.Write(value: $"{msg}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(value: ex);
            }
        }
    }
}
