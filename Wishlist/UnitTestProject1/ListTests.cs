using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var objPeople = new People();

            List<People> peoplelist = objPeople.RetrieveWishers();
            //Act
            //Analyze
            //Assert

        }
    }
}
