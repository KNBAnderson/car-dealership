using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Models {

  public class Car
  {
    public string MakeModel {get; set;}
    public int Price {get; set;}
    public int Miles {get; set;}
    public string Info {get; set;}
    public static List<Car> CarsList {get; set;} = new List<Car> {};
    public int Id {get; set;}

    public Car(string makeModel, int price, int miles, string infoAboutCar)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Info = infoAboutCar;
      CarsList.Add(this);
      Id = CarsList.Count;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }

    public bool MileageCount(int maxMiles)
    {
      return (Miles < maxMiles);
    }

    public static void RemoveCar(int id)
    {
      CarsList.Remove(CarsList[id - 1]);
    }

    public static void ClearAll()
    {
      CarsList.Clear();
    }

    public static Car Find(int searchId)
    {
      return CarsList[searchId-1];
    }
  }
}
