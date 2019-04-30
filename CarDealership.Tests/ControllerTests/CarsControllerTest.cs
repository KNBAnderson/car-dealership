using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dealership.Controllers;
using Dealership.Models;

namespace Dealership.Tests
{
  [TestClass]
  public class CarsControllerTest
  {

    [TestMethod]
    public void Index_HasCorrectModelType_CarsList()
    {
      //Arrange

      ViewResult indexView = new CarsController().Index() as ViewResult;

      //Act
      var result = indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Car>));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
        //Arrange
        CarsController controller = new CarsController();

        //Act
        IActionResult view = controller.CreateCar("Barbie Dream Car", 12, 32, "This is a car");

        //Assert
        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
        //Arrange
        CarsController controller = new CarsController();
        RedirectToActionResult actionResult = controller.CreateCar("Barbie Dream Car", 12, 32, "This is a car") as RedirectToActionResult;

        //Act
        string result = actionResult.ActionName;

        //Assert
        Assert.AreEqual(result, "Index");
    }
  }
}
