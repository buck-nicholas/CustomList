using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Int_InsertIntValueToList()
        {
            CustomList.ListMethod<int> listMethods = new CustomList.ListMethod<int>();
            //Arrange
            int expectedValue = 10;
            //Act
            listMethods.Add(expectedValue);
            int actualValue = listMethods[0];
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Add_Int_InsertMultipleIntValuesToList()
        {
            CustomList.ListMethod<int> listMethods = new CustomList.ListMethod<int>();
            //Arrange
            int expectedValueOne = 10;
            int expectedValueTwo = 11;
            int expectedValueThree = 12;
            int expectedValueFour = 13;
            int expectedValueFive = 14;
            //Act
            listMethods.Add(expectedValueOne);
            listMethods.Add(expectedValueTwo);
            listMethods.Add(expectedValueThree);
            listMethods.Add(expectedValueFour);
            listMethods.Add(expectedValueFive);
            //Assert
            int actualValue = listMethods[4];
            Assert.AreEqual(expectedValueFive, actualValue);
        }
        [TestMethod]
        public void Add_Double_InsertDoubleValueToList()
        {
            CustomList.ListMethod<double> listMethods = new CustomList.ListMethod<double>();
            //Arrange
            double expectedValue = .10;
            //Act
            listMethods.Add(expectedValue);
            double actualValue = listMethods[0];
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Add_Int_InsertMultipleDoubleValuesToList()
        {
            CustomList.ListMethod<double> listMethods = new CustomList.ListMethod<double>();
            //Arrange
            double expectedValueOne = .10;
            double expectedValueTwo = .11;
            double expectedValueThree = .12;
            double expectedValueFour = .13;
            double expectedValueFive = .14;
            //Act
            listMethods.Add(expectedValueOne);
            listMethods.Add(expectedValueTwo);
            listMethods.Add(expectedValueThree);
            listMethods.Add(expectedValueFour);
            listMethods.Add(expectedValueFive);
            //Assert
            double actualValue = listMethods[4];
            Assert.AreEqual(expectedValueFive, actualValue);
        }
        [TestMethod]
        public void Add_Float_InsertFloatValueToList()
        {
            CustomList.ListMethod<float> listMethods = new CustomList.ListMethod<float>();
            //Arrange
            float expectedValue = 1.00010F;
            //Act
            listMethods.Add(expectedValue);
            float actualValue = listMethods[0];
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Add_Int_InsertMultipleFloatValuesToList()
        {
            CustomList.ListMethod<float> listMethods = new CustomList.ListMethod<float>();
            //Arrange
            float expectedValueOne = 1.00010F;
            float expectedValueTwo = 1.00020F;
            float expectedValueThree = 1.00030F;
            float expectedValueFour = 1.00030F;
            float expectedValueFive = 1.00040F;
            //Act
            listMethods.Add(expectedValueOne);
            listMethods.Add(expectedValueTwo);
            listMethods.Add(expectedValueThree);
            listMethods.Add(expectedValueFour);
            listMethods.Add(expectedValueFive);
            //Assert
            float actualValue = listMethods[4];
            Assert.AreEqual(expectedValueFive, actualValue);
        }
        [TestMethod]
        public void Add_Short_InsertShortValueToList()
        {
            CustomList.ListMethod<short> listMethods = new CustomList.ListMethod<short>();
            //Arrange
            short expectedValue = 1337;
            //Act
            listMethods.Add(expectedValue);
            short actualValue = listMethods[0];
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Add_Int_InsertMultipleShortValuesToList()
        {
            CustomList.ListMethod<short> listMethods = new CustomList.ListMethod<short>();
            //Arrange
            short expectedValueOne = 1337;
            short expectedValueTwo = 1338;
            short expectedValueThree = 1339;
            short expectedValueFour = 1340;
            short expectedValueFive = 1341;
            //Act
            listMethods.Add(expectedValueOne);
            listMethods.Add(expectedValueTwo);
            listMethods.Add(expectedValueThree);
            listMethods.Add(expectedValueFour);
            listMethods.Add(expectedValueFive);
            //Assert
            short actualValue = listMethods[4];
            Assert.AreEqual(expectedValueFive, actualValue);
        }
        [TestMethod]
        public void Add_Str_InsertStrValueToList()
        {
            CustomList.ListMethod<string> listMethods = new CustomList.ListMethod<string>();
            //Arrange
            string expectedValue = "ABCDEFGHIJKLmnopqrstuvwxyz";
            //Act
            listMethods.Add(expectedValue);
            string actualvalue = listMethods[0];
            //Assert
            Assert.AreEqual(expectedValue, actualvalue);
        }
        [TestMethod]
        public void Add_Int_InsertMultipleStringValuesToList()
        {
            CustomList.ListMethod<string> listMethods = new CustomList.ListMethod<string>();
            //Arrange
            string expectedValueOne = "ABC";
            string expectedValueTwo = "ABCD";
            string expectedValueThree = "ABCDE";
            string expectedValueFour = "ABCDEF";
            string expectedValueFive = "ABCDEFG";
            //Act
            listMethods.Add(expectedValueOne);
            listMethods.Add(expectedValueTwo);
            listMethods.Add(expectedValueThree);
            listMethods.Add(expectedValueFour);
            listMethods.Add(expectedValueFive);
            //Assert
            string actualValue = listMethods[4];
            Assert.AreEqual(expectedValueFive, actualValue);
        }
        [TestMethod]
        public void Add_Array_InsertArrayValueIntoList()
        {
            CustomList.ListMethod<Array> listMethods = new CustomList.ListMethod<Array>();
            //Arrange
            Array expectedValue = new Array[0];
            //Act
            listMethods.Add(expectedValue);
            Array actualValue = listMethods[0];
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod]
        public void Add_Int_InsertMultipleArrayValuesToList()
        {
            CustomList.ListMethod<Array> listMethods = new CustomList.ListMethod<Array>();
            //Arrange
            Array expectedValueOne = new Array[0];
            Array expectedValueTwo = new Array[0];
            Array expectedValueThree = new Array[0];
            Array expectedValueFour = new Array[0];
            Array expectedValueFive = new Array[0];
            //Act
            listMethods.Add(expectedValueOne);
            listMethods.Add(expectedValueTwo);
            listMethods.Add(expectedValueThree);
            listMethods.Add(expectedValueFour);
            listMethods.Add(expectedValueFive);
            //Assert
            Array actualValue = listMethods[4];
            Assert.AreEqual(expectedValueFive, actualValue);
        }
        [TestMethod]
        public void Remove_Element_RemoveASingleElementFromList()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
