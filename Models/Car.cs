using System;

namespace Dealership {

class Car
{
  private string MakeModel;
  private int Price;
  private int Miles;
  private string Info;

  public void SetPrice(int newPrice)
   {
     Price = newPrice;
   }

  public Car(string makeModel, int price, int miles, string infoAboutCar)
 {
   MakeModel = makeModel;
   Price = price;
   Miles = miles;
   Info = infoAboutCar;
 }

 public string GetMakeModel()
  {
    return MakeModel;
  }

  public int GetPrice()
  {
    return Price;
  }

  public int GetMiles()
  {
    return Miles;
  }

  public string GetInfoAboutCar()
  {
    return Info;
  }

  public bool WorthBuying(int maxPrice)
{
  return (Price < maxPrice);
  }
}
}
