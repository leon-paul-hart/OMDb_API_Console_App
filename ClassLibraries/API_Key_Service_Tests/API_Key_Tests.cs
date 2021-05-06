using API_Key_Service;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API_Key_Service_Tests
{
    [TestClass]
    public class API_Key_Tests
    {
        [TestMethod]
        public void APIKeyConstructorCanAssignValue()
        {
            //Arrange
            APIKeyManager key = new(Key_Value: "ABC123");

            //Act

            //Assert
            Assert.AreEqual(expected: key.GetAPIKeyFromCache(), actual: "ABC123");
        }

        [TestMethod]
        public void GetAPIKey()
        {
            //Arrange
            APIKeyManager key = new(Key_Value: "GHI789");

            //Act

            //Assert
            Assert.AreEqual(expected: key.GetAPIKeyFromCache(), actual: "GHI789");
        }

        [TestMethod]
        public void SetApiKey()
        {
            //Arrange
            APIKeyManager key = new(Key_Value: "ABC123");

            //Act
            key.WriteAPIKeyToCache(new_Key_Value: "DEF456");

            //Assert
            Assert.AreEqual(expected: key.GetAPIKeyFromCache(), actual: "DEF456");
        }
    }
}
