using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OMDb_API_Console_App
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            DisplayIntroduction();

            string APIKey = GetAPIKey(args.ToString());

            await ApiQuery(APIKey);
        }

        private static void DisplayIntroduction()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the OMDb (Open Movie Database) API Explorer Console App");
            Console.WriteLine("To use this application you will need a valid API key");
            Console.WriteLine("You can register for an API key for free at https://www.omdbapi.com/apikey.aspx" + System.Environment.NewLine);
            Console.ResetColor();
        }

        private static string GetAPIKey(string APIKey)
        {
            if (APIKey.Length == 8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You are using the API key : " + APIKey);
                Console.ResetColor();
                return APIKey;
            }
            else
            {
                while (APIKey.Length != 8)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please enter a valid OMDb API key");
                    Console.ResetColor();
                    APIKey = Console.ReadLine();
                }
                return APIKey;
            }
        }

        private static async Task ApiQuery(string APIKey)
        {
            try
            {
                Task<string> stringTask = client.GetStringAsync(System.Environment.NewLine + "https://www.omdbapi.com/?i=tt3896198&apikey=" + APIKey.ToString());

                string msg = await stringTask;

                Console.Clear();
                Console.Write(msg);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
