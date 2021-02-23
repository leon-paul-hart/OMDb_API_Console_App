namespace API_Key_Service.APIKeyManager
{
    public class APIKeyManager
    {
        private string API_Key {get; set;}

        public APIKeyManager(string Key_Value){
            API_Key = Key_Value;
        }

        public string GetAPIKey(){
            return API_Key;
        }

        public void SetAPIKey(string new_Key_Value){
            API_Key = new_Key_Value;
        }
    }
}