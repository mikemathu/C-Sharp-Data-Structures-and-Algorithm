using DSA.DataStructures.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsertionTests
{
    [TestClass]
    public class DeletionTests
    {
        [TestMethod]
        public void DeleteSingleElementAtTheBegginingTest()
        {
            //Arrange
            Deletion element = new Deletion();

            //Act
            int elementDeleted = element.DeleteSingleElementAtTheBeggining();

            //Assert
            Assert.AreEqual(20, elementDeleted);
        }

        [TestMethod]
        public void DeleteSingleElementAtTheEndTest()
        {
            //Arrange
            Deletion element = new Deletion();

            //Act
            int elementDeleted = element.DeleteSingleElementAtTheEnd();

            //Assert
            Assert.AreEqual(20, elementDeleted);
        }
    }
}