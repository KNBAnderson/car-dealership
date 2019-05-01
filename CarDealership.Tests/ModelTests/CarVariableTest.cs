using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dealership.Models;
using System;

namespace Dealership.Tests
{
  [TestClass]
  public class CarsVariableTest : IDisposable
  {
    public void Dispose()
    {
      Car.ClearAll();
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange

      Car newCar = new Car("catCar", 5, 200, "is great.");

      //Act
      int result = newCar.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Delete_DeleteCorrectItem_Item()
    {
      //Arrange
      Car newCar4 = new Car("car", 3, 54, "lkdjfdskj");
      Car newCar5 = new Car("car", 3, 54, "lkdjfdskj");


      //Act
      Car.RemoveCar(2);
      int result = Car.CarsList.Count;
      //Assert
      Assert.AreEqual(1, result);
    }
  }
}
