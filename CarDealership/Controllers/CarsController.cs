using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System;

namespace Dealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {

      List<Car> allCars = Car.CarsList;
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles, string infoAboutCar)
    {
      Car newCar = new Car(makeModel, price, miles, infoAboutCar);
      return RedirectToAction("Index");
    }

    // [HttpPost("/cars/delete")]
    // public ActionResult Index()
    // {
    //   Car.RemoveCar(this);
    //   return View();
    // }
  
  }
}
