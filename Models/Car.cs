using System;

namespace Dealership.Models {

  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private int _topSpeed;


    public Car(string makeModel, int price, int miles, int topSpeed)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _topSpeed = topSpeed;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public int GetSpeed()
    {
      return _topSpeed;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }
  }

}