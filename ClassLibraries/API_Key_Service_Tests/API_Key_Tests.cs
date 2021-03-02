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
    }
}
