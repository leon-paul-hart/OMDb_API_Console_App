using Microsoft.VisualStudio.TestTools.UnitTesting;

using API_Key_Service.APIKeyManager;

namespace API_Key_Service_Tests
{
    [TestClass]
    public class API_Key_Tests
    {
        [TestMethod]
        public void APIKeyIsNull()
        {
            //Arrange
            APIKeyManager key = new APIKeyManager();

            //Act

            //Assert
            Assert.IsNull(key.API_Key);
        }
    }
}
