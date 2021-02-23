namespace API_Key_Service.APIKeyManager
{
    public class APIKeyManager
    {
        #region Properties
        
        private string API_Key {get; set;}
        
        #endregion

        #region Constructors
        
        public APIKeyManager(string Key_Value){
            API_Key = Key_Value;
        }
        
        #endregion

        #region Public Methods
        
        public string GetAPIKey(){
            return API_Key;
        }

        public void SetAPIKey(string new_Key_Value){
            API_Key = new_Key_Value;
        }

        #endregion
    }
}