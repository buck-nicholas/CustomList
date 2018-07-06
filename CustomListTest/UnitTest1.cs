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
        //[TestMethod]
        //public void Add_Double_InsertDoubleValueToList()
        //{
        //    CustomList.ListMethod<double> listMethods = new CustomList.ListMethod<double>();
        //    //Arrange
        //    double expectedValue = .10;
        //    double actualValue = listMethods[0];
        //    //Act
        //    listMethods.Add(expectedValue);
        //    //Assert
        //    Assert.AreEqual(expectedValue, actualValue);
        //}
        //[TestMethod]
        //public void Add_Float_InsertFloatValueToList()
        //{
        //    CustomList.ListMethod<float> listMethods = new CustomList.ListMethod<float>();
        //    //Arrange
        //    float expectedValue = 1.00010F;
        //    float actualValue = listMethods[0];
        //    //Act
        //    listMethods.Add(expectedValue);
        //    //Assert
        //    Assert.AreEqual(expectedValue, actualValue);
        //}
        //[TestMethod]
        //public void Add_Short_InsertShortValueToList()
        //{
        //    CustomList.ListMethod<short> listMethods = new CustomList.ListMethod<short>();
        //    //Arrange
        //    short expectedValue = 1337;
        //    short actualValue = listMethods[0];
        //    //Act
        //    listMethods.Add(expectedValue);
        //    //Assert
        //    Assert.AreEqual(expectedValue, actualValue);
        //}
        //[TestMethod]
        //public void Add_Str_InsertStrValueToList()
        //{
        //    CustomList.ListMethod<string> listMethods = new CustomList.ListMethod<string>();
        //    //Arrange
        //    string expectedValue = "ABCDEFGHIJKLmnopqrstuvwxyz";
        //    string actualvalue = listMethods[0];
        //    //Act
        //    listMethods.Add(expectedValue);
        //    //Assert
        //    Assert.AreEqual(expectedValue, actualvalue);
        //}
        ////[TestMethod]
        ////public void Add_Obj_InsertObjValueIntoList()
        ////{
        ////    CustomList.ListMethod<object> listMethods = new CustomList.ListMethod<object>();
        ////    //Arrange
        ////    object expectedValue()
        ////    {

        ////    }
        ////    object actualValue = listMethods[0];
        ////    //Act
        ////    listMethods.Add(expectedValue);
        ////    //Assert
        ////    Assert.AreEqual(expectedValue, actualValue);
        ////}
        //[TestMethod]
        //public void Add_Array_InsertArrayValueIntoList()
        //{
        //    CustomList.ListMethod<Array> listMethods = new CustomList.ListMethod<Array>();
        //    //Arrange
        //    Array expectedValue = new Array[0];
        //    Array actualValue = listMethods[0];
        //    //Act
        //    listMethods.Add(expectedValue);
        //    //Assert
        //    Assert.AreEqual(expectedValue, actualValue);
        //}
    }
}
