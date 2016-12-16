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
            CustomList<int> newList = new CustomList<int>();
            int item = 1;
            newList.Add(item);
            int lists = newList.list[0];

            //Act
            int result = newList.Count;

            //Assert
            Assert.AreEqual(result, 1);
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
        public void CheckCountOnAdd4()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            newList.Count = 0;
            int expectedResult = 21;

            //Act
            newList.Add(1100000);
            newList.Add(1700);
            newList.Add(2400);
            newList.Add(80000);
            newList.Add(1300);
            newList.Add(56600);
            newList.Add(40);
            newList.Add(5678);
            newList.Add(9876);
            newList.Add(3648);
            newList.Add(9363);
            newList.Add(2);
            newList.Add(1100);
            newList.Add(5200);
            newList.Add(804);
            newList.Add(56);
            newList.Add(5201);
            newList.Add(5324);
            newList.Add(644);
            newList.Add(587);
            newList.Add(9999);

            //Assert
            Assert.AreEqual(expectedResult, newList.Count);
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
        public void DisplayList3()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            newList.Add(1100);
            newList.Add(5200);
            newList.Add(804);
            newList.Add(56);
            newList.Add(5201);
            newList.Add(5324);
            newList.Add(644);
            newList.Add(587);
            newList.Add(9999);
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
            CustomList<int> newList = new CustomList<int>();
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);
            newList.Add(4);
            int expectedResult = 3;

            //Act
            newList.Remove(2);

            //Assert
            Assert.AreEqual(expectedResult, newList.Count);
        }

        [TestMethod]
        public void CheckCountOnRemove2()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            newList.Add(101);
            newList.Add(38);
            newList.Add(72);
            newList.Add(56);
            newList.Add(44);
            newList.Add(8);
            newList.Add(90);
            newList.Add(4);
            int expectedResult = 7;

            //Act
            newList.Remove(44);

            //Assert
            Assert.AreEqual(expectedResult, newList.Count);
        }

        [TestMethod]
        public void CheckCountOnRemove3()
        {
            //Arrange
            CustomList<int> newList = new CustomList<int>();
            newList.Add(2300);
            newList.Add(1100000);
            newList.Add(1700);
            newList.Add(2400);
            newList.Add(80000);
            newList.Add(1300);
            newList.Add(56600);
            newList.Add(40);
            newList.Add(5678);
            newList.Add(9876);
            newList.Add(3648);
            newList.Add(9363);
            newList.Add(2);
            int expectedResult = 12;

            //Act
            newList.Remove(56600);

            //Assert
            Assert.AreEqual(expectedResult, newList.Count);
        }
    }
}