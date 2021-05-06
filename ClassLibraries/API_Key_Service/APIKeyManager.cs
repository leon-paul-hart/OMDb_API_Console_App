namespace API_Key_Service
{
    public class APIKeyManager
    {
        #region Properties

        private string API_Key { get; set; }
        // TODO Move API_Key to a POCO with Validation Attributes

        #endregion

        #region Constructors

        public APIKeyManager(string Key_Value)
        {
            if (string.IsNullOrWhiteSpace(Key_Value))
            {
                throw new System.ArgumentException(message: $"'{nameof(Key_Value)}' cannot be null or whitespace.", paramName: nameof(Key_Value));
            }

            API_Key = Key_Value;
        }

        #endregion

        #region Public Methods

        public string GetAPIKeyFromCache()
        {
            return API_Key;
        }

        public void WriteAPIKeyToCache(string new_Key_Value)
        {
            if (string.IsNullOrWhiteSpace(value: new_Key_Value))
            {
                throw new System.ArgumentException(message: $"'{nameof(new_Key_Value)}' cannot be null or whitespace.", paramName: nameof(new_Key_Value));
            }

            API_Key = new_Key_Value;
        }

        //TODO 

        // Add Method to write API_Key to file

        // Add Method to get API_Key from file

        #endregion
    }
}