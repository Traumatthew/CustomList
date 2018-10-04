using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomListProject;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_TestMethod1()
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
        public void Add_TestMethod2()
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
        public void Add_TestMethod3()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;


            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        [TestMethod]
        public void Remove_TestMethod1()
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
        public void Remove_TestMethod2()
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
        public void AdditionOverload_TwoStrings()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>(); {
            CustomList<int> two = new CustomList<int>();
            one.Add(1);
            one.Add(2);
            one.Add(3);
            two.Add(4);
            two.Add(5);
            two.Add(6);

            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);

            //Act
            CustomList<int> result = one + two;

            //Assert
            Assert.AreEqual(expectedResult[3], result[3]);
        }
        public void MinusOverload_TwoStrings()
        {
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);
            odd.Add(7);

            even.Add(2);
            even.Add(4);
            even.Add(6);
            even.Add(8);

            CustomList<int> expectedResult = new CustomList<int>();
            expectedResult.Remove(1);
            expectedResult.Remove(2);

            //Act
            CustomList<int> result = odd - even;

            //Assert

            Assert.AreEqual(expectedResult[3], result[]);


        }
    }
}