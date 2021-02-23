using Microsoft.VisualStudio.TestTools.UnitTesting;

using API_Key_Service.APIKeyManager;

namespace API_Key_Service_Tests
{
    [TestClass]
    public class API_Key_Tests
    {
        [TestMethod]
        public void APIKeyConstructorCanAssignValue()
        {
            //Arrange
            APIKeyManager key = new APIKeyManager("ABC123");

            //Act

            //Assert
            Assert.AreEqual(key.GetAPIKey(), "ABC123");
        }

        [TestMethod]
        public void GetAPIKey()
        {
            //Arrange
            APIKeyManager key = new APIKeyManager("GHI789");

            //Act

            //Assert
            Assert.AreEqual(key.GetAPIKey(), "GHI789");
        }

        [TestMethod]
        public void SetApiKey()
        {
            //Arrange
            APIKeyManager key = new APIKeyManager("ABC123");

            //Act
            key.SetAPIKey("DEF456");

            //Assert
            Assert.AreEqual(key.GetAPIKey(), "DEF456");
        }
    }
}
