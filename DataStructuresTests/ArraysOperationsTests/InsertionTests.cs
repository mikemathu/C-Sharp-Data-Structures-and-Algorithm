using DSA.DataStructures.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InsertionTests
{
    [TestClass]
    public class InsertionTests
    {
        [TestMethod]
        public void InsertSingleElementAtBeginningReturnThatElementTest()
        {
            //Arrange
            Insertion element = new Insertion();

            //Act
             int elementInserted = element.InsertSingleElementAtTheBeginning(3);
            //ssert
            Assert.AreEqual(3, elementInserted);
        }

        [TestMethod]
        public void InsertArrayAtBeginningTestReturnAccessedElementsTet()
        {
            //Arrange
            Insertion array = new Insertion();

            //Act
            int[] arrayElements =  { 1, 2, 3, 4 };
            int arrayInserted = array.InsertArrayAtTheBeginning(arrayElements);
            //ssert
            Assert.AreEqual(4, arrayInserted);
        }

        [TestMethod]
        public void InsertSingleElementAtEndReturnThatElementTest()
        {
            //Arrange
            Insertion element = new Insertion();
            //Act         

            int elementInserted = element.InsertSingleElementAtTheEnd(14);

            //Assert
            Assert.AreEqual(14, elementInserted);
        }

        [TestMethod]
        public void InsertSingleElementAtMiddleReturnThatElementTest()
        {
            //Arrange
            Insertion element = new Insertion();
            //Act         

            int elementInserted = element.InsertSingleElementAtTheMiddle(90,15);

            //Assert
            Assert.Fail();
        }

        /*  [TestMethod]
          public void InsertToExceedingPositionThrowException()
          {
              //Arrange
              Insertion element = new Insertion();
              //Act         

              int elementInserted = element.InsertSingleElementAtTheMiddle(90, 15);

              //Assert
              Assert.Fail();
          }*/

        [TestMethod]
        public void InsertSingleElementAtMiddleofUnsortedArrayTest()
        {
            //Arrange
            Insertion element = new Insertion();
            //Act         

            int elementInserted = element.InsertSingleElementAtTheMiddleOfUnsortedArray(2, 20);

            //Assert
            Assert.AreEqual(20, elementInserted);
        }

    }
}