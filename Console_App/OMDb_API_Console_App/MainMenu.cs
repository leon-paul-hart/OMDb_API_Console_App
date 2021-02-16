using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OMDb_API_Console_App
{
    class MainMenu
    {
        private static readonly HttpClient client = new HttpClient();

        private static ConsoleAlerts alerts = new ConsoleAlerts();

        static async Task Main(string[] args)
        {
            DisplayIntroduction();

            string APIKey = GetAPIKey(args.ToString());
            
            using (client)
            {
                await ApiQuery(APIKey);
            }
        }

        private static void DisplayIntroduction()
        {
            Console.Clear();
            alerts.ChangeStringColour("Welcome to the (Unofficial) OMDb (Open Movie Database) API Explorer Console App", ConsoleColor.Green);
            alerts.ChangeStringColour("To use this application you will need a valid API key", ConsoleColor.Green);
            alerts.ChangeStringColour("You can register for an API key for free at https://www.omdbapi.com/apikey.aspx" + System.Environment.NewLine,  ConsoleColor.Green);
        }

        private static string GetAPIKey(string APIKey)
        {
            if (APIKey.Length == 8)
            {
                alerts.ChangeStringColour("You are using the API key : " + APIKey, ConsoleColor.Green);
                return APIKey;
            }
            else
            {
                while (APIKey.Length != 8)
                {
                    alerts.ChangeStringColour("Please enter a valid OMDb API key", ConsoleColor.Yellow);
                    APIKey = Console.ReadLine();
                }
                return APIKey;
            }
        }

        private static async Task ApiQuery(string APIKey)
        {
            try
            {
                Task<string> stringTask = client.GetStringAsync(System.Environment.NewLine + "https://www.omdbapi.com/?s=princess&apikey=" + APIKey.ToString());

                string msg = await stringTask;

                Console.Clear();

                Console.Write(msg + "\n");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
