using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OMDb_API_Console_App
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        public string APIKey { get; set; }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to the OMDb (Open Movie Database) API Explorer Console App");
            Console.WriteLine("To use this application you will need a valid API key");
            Console.WriteLine("You can register for an API key for free at https://www.omdbapi.com/apikey.aspx");

            string APIKey = GetAPIKey(args.ToString());

            await ProcessRepositories(APIKey);
        }

        private static string GetAPIKey(string APIKey)
        {
            if (APIKey.Length == 8)
            {
                Console.WriteLine("You are using the API key : " + APIKey);
                return APIKey;
            }
            else
            {
                while (APIKey.Length != 8)
                {
                    Console.WriteLine("Please enter a valid OMDb API key");
                    APIKey = Console.ReadLine();
                }
                return APIKey;
            }
        }

        private static async Task ProcessRepositories(string APIKey)
        {
            Task<string> stringTask = client.GetStringAsync("https://www.omdbapi.com/?i=tt3896198&apikey=" + APIKey.ToString());

            string msg = await stringTask;

            Console.Write(msg);
        }
    }
}
