using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomListProject;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomList<int> customList = new CustomList<int>();
        }
    }
}
