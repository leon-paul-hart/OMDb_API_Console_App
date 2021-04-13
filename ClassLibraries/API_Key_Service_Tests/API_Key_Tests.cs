using Microsoft.VisualStudio.TestTools.UnitTesting;

using API_Key_Service.APIKeyManager;

namespace API_Key_Service_Tests
{
    [TestClass]
    public class API_Key_Tests
    {
        [TestMethod]
        public void Can_Read_And_Write_API_Key_To_File()
        {
            //Arrange
            APIKeyManager keyManager = new APIKeyManager();

            //Act
            keyManager.SetAPIKey("ABCD1234");

            //Assert
            Assert.AreEqual("ABCD1234", keyManager.GetAPIKey());
        }

        [TestMethod]
        public void Can_Set_Api_Key_To_File()
        {
            //Arrange
            APIKeyManager keyManager = new APIKeyManager();

            //Act
            keyManager.SetAPIKey("DEFG5678");

            //Assert
            Assert.AreEqual("DEFG5678", keyManager.GetAPIKey());
        }

        [TestMethod]
        public void Can_Change_Existing_Api_Key_In_File()
        {
            //Arrange
            APIKeyManager keyManager = new APIKeyManager();

            //Act
            keyManager.SetAPIKey("HIJK9101");

            //Assert
            Assert.AreEqual("HIJK9101", keyManager.GetAPIKey());

            //Arrange
            APIKeyManager keyManager2 = new APIKeyManager();

            //Act
            keyManager2.SetAPIKey("LMNO1112");
            
            //Assert
            Assert.AreEqual("LMNO1112", keyManager2.GetAPIKey());
        }

        [TestMethod]
        public void API_Key_Cannot_Be_More_Than_Eight_Characters()
        {
            //Arrange
            APIKeyManager keyManager = new APIKeyManager();

            //Act
            bool APIKeyIsValid = keyManager.ValidateAPIKey("PQRS131415");

            //Assert
            Assert.IsFalse(APIKeyIsValid);
        }

        [TestMethod]
        public void API_Key_Cannot_Be_Less_Than_Eight_Characters()
        {
            //Arrange
            APIKeyManager keyManager = new APIKeyManager();

            //Act
            bool APIKeyIsValid = keyManager.ValidateAPIKey("TUV1617");

            //Assert
            Assert.IsFalse(APIKeyIsValid);
        } 

        [TestMethod]
        public void API_Key_Equals_Eight_Characters()
        {
            //Arrange
            APIKeyManager keyManager = new APIKeyManager();

            //Act
            bool APIKeyIsValid = keyManager.ValidateAPIKey("WXYZ1819");

            //Assert
            Assert.IsTrue(APIKeyIsValid);
        } 
    }
}
