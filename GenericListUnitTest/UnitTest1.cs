using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace GenericListUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckCountOnAdd1()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Count = 0;
            int expectedResult = 1;

            //Act
            list.Add(76);

            //Assert
            Assert.AreEqual(expectedResult, list.Count);
        }

        [TestMethod]
        public void CheckCountOnAdd2()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Count = 0;
            int expectedResult = 2;

            //Act
            list.Add(87);
            list.Add(92);

            //Assert
            Assert.AreEqual(expectedResult, list.Count);
        }

        [TestMethod]
        public void CheckCountOnAdd3()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Count = 0;
            int expectedResult = 8;

            //Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);

            //Assert
            Assert.AreEqual(expectedResult, list.Count);
        }

        [TestMethod]
        public void DisplayList1()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            int item1 = 1;
            int item2 = 2;
            int item3 = 3;
            int list = newList.list[0];

            //Act
            newList.Display();
            int actualResult = newList.list[0];

            //Assert
            Assert.AreEqual(list, actualResult);
        }

        [TestMethod]
        public void DisplayList2()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            newList.Add(33);
            newList.Add(52);
            newList.Add(84);
            int item1 = 33;
            int item2 = 52;
            int item3 = 84;
            int list = newList.list[0];

            //Act
            newList.Display();
            int actualResult = newList.list[0];

            //Assert
            Assert.AreEqual(list, actualResult);
        }

        [TestMethod]
        public void CheckCountOnRemove1()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Count = 2;
            int expectedResult = 1;

            //Act
            list.Remove(32);

            //Assert
            Assert.AreEqual(expectedResult, list.Count);
        }

        [TestMethod]
        public void CheckCountOnRemove2()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Count = 10;
            int expectedResult = 9;

            //Act
            list.Remove(34);

            //Assert
            Assert.AreEqual(expectedResult, list.Count);
        }

        [TestMethod]
        public void CheckCountOnRemove3()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Count = 25;
            int expectedResult = 24;

            //Act
            list.Remove(44);

            //Assert
            Assert.AreEqual(expectedResult, list.Count);
        }

        [TestMethod]
        public void CheckIteration1()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            newList.Add(1);
            newList.Add(3);
            newList.Add(5);
            int item1 = 1;
            int item2 = 3;
            int item3 = 5;
            int list = newList.list[0];

            //Act
            newList.CheckIteration();
            int actualResult = newList.list[0];

            //Assert
            Assert.AreEqual(list, actualResult);
        }

        [TestMethod]
        public void CheckIteration2()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            newList.Add(2);
            newList.Add(4);
            newList.Add(6);
            int item1 = 2;
            int item2 = 4;
            int item3 = 6;
            int list = newList.list[0];

            //Act
            newList.CheckIteration();
            int actualResult = newList.list[0];

            //Assert
            Assert.AreEqual(list, actualResult);
        }
    }
}