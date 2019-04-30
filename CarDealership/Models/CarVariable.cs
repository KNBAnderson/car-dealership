using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Models {

  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _info;
    private static List<Car> _carsList = new List<Car> {};

    public Car(string makeModel, int price, int miles, string infoAboutCar)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _info = infoAboutCar;
      _carsList.Add(this);
    }

    public string MakeModel { get => _makeModel; set => _makeModel = value; }

    public int Price { get => _price; set => _price = value; }

    public int Miles { get => _miles; set => _miles = value; }

    public string InfoAboutCar { get => _info; set => _info = value; }

    public static List<Car> CarsList { get => _carsList; set => _carsList = value; }

    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }

    public bool MileageCount(int maxMiles)
    {
      return (_miles < maxMiles);
    }

    public static void RemoveCar(Car car)
    {
      _carsList.Remove(car);
    }
  }
}
