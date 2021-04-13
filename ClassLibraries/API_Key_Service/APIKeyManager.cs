using System.IO;
using System;

namespace API_Key_Service.APIKeyManager
{
    public class APIKeyManager : IAPI_Key_Service
    {
        #region Properties
        
        private readonly StreamWriter writer = new StreamWriter("/home/leon/Documents/Dotnet-Projects/OMDb_API_Console_App/ClassLibraries/API_Key_Service/api_key.user");
        private readonly StreamReader reader = new StreamReader("/home/leon/Documents/Dotnet-Projects/OMDb_API_Console_App/ClassLibraries/API_Key_Service/api_key.user");

        #endregion

        #region Public Methods
        
        public string GetAPIKey(){
            return ReadAPIKeyFromFile();
        }

        public void SetAPIKey(string new_Key_Value){
            WriteAPIKeyToFile(new_Key_Value);
        }

        public void WriteAPIKeyToFile(string API_Key){
            try
            {
                using (writer)
                {
                    writer.WriteLine(API_Key);
                }   
            }
            catch (System.Exception ex) 
            {
                Console.WriteLine("Error attempting to write API Key to file : " + ex.Message);
            }
        }

        public string ReadAPIKeyFromFile(){
            try
            {
                using (reader)
                {
                    string key = reader.ReadLine();
                    return key;
                }   
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Error attempting to read API Key from file : " + ex.Message);
                return null;
            }
        }

        public bool ValidateAPIKey(string key){
            try
            {
               if (key.Length > 8 || key.Length < 8)
               {
                   return false;
               }
               else
               {
                   return true;
               }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Error attempting to validate OMDb API Key : " + ex.Message);
                throw;
            }
        }

        #endregion
    }
}