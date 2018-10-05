using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomListProject;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ItemtoArray()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;

            //Act
            customList.Add(value);

            //Assert
            Assert.AreEqual(value, customList[0]);
        }
   

        [TestMethod]
        public void Add_CheckCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int countValue = 1;

            //Act
            customList.Add(value);

            //Assert
            Assert.AreEqual(customList.Count, countValue);
        }

        [TestMethod]
        public void Add_TwoItems()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;


            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual(value, value1, customList[0]);
        }
        [TestMethod]
        public void MakeArrayLarger()
        {
            //Arrange
            int expectedCount = 6;
            CustomList<int> listone = new CustomList<int>();

            listone.Add(1);
            listone.Add(2);
            listone.Add(3);
            listone.Add(4);
            listone.Add(5);
            listone.Add(6);

            //Act
            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);
              
            //Assert
            Assert.AreEqual(expectedCount, listone.Count);
            
        }

        [TestMethod]
        public void CheckIndex_OfArray()
        {
            //Arrange
            CustomList<int> listone = new CustomList<int>();
            listone.Add(1);
            listone.Add(2);
            listone.Add(3);
            listone.Add(4);
            listone.Add(5);
            listone.Add(6);

                //Act
                CustomList<int> expectedResult = new CustomList<int>();
                expectedResult.Add(1);
                expectedResult.Add(2);
                expectedResult.Add(3);
                expectedResult.Add(4);
                expectedResult.Add(5);
                expectedResult.Add(6);

                //Assert
                Assert.AreEqual(expectedResult[5], listone[5]);
            
        }

        [TestMethod]
        public void Remove_NumberFromList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 1;

            //Act
            customList.Add(value);
            customList.Add(value1);
            customList.Remove(value);

            //Assert
            Assert.AreEqual(value1, customList[0]);
        }

        [TestMethod]
        public void Remove_Number_CheckCount()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 39;
            int countValue = 1;

            //Act
            customList.Add(value);
            customList.Add(value1);
            customList.Remove(value);

            //Assert
            Assert.AreEqual(customList.Count, countValue);
        }

        [TestMethod]
        public void Remove_TestMethod3()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;


            //Act
            customList.Remove(value);
            customList.Remove(value1);

            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        [TestMethod]
        public void IteratorTest()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Add(value6);

            //Assert


        }

        [TestMethod]
        public void Add_TwoLists_Together()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>(); 
            CustomList<int> listTwo = new CustomList<int>();
            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);

            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);

            //Act
            CustomList<int> result = listOne + listTwo;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Zip_TwoLists_Together()
        {
            //Arrange
            CustomList<int> oddList = new CustomList<int>();
            CustomList<int> evenList = new CustomList<int>();
            oddList.Add(1);
            oddList.Add(3);
            oddList.Add(5);
            oddList.Add(7);

            evenList.Add(2);
            evenList.Add(4);
            evenList.Add(6);
            evenList.Add(8);

            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);
            expectedResult.Add(7);
            expectedResult.Add(8);

            //Act
            CustomList<int> result = oddList + evenList;

            //Assert

            Assert.AreEqual(expectedResult[], result[]);

          
        }
    }
}