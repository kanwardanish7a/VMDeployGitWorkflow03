using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyVmDeploy.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Addition_TwoPlusTwo_EqualsFour()
        {
            // Arrange
            int a = 2;
            int b = 2;

            // Act
            int result = a + b;

            // Assert
            Assert.AreEqual(4, result);
        }
    }
}
