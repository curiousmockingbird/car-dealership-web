using System;

namespace Dealership.Models {

  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private int _topSpeed;
    private int _year;


    public Car(string makeModel, int price, int miles, int topSpeed, int year)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _topSpeed = topSpeed;
      _year = year;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetYear()
    {
      return _year;
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

    public string Placement()
    {
      if (_topSpeed > 90) {
        return "good car";
      } else {
        return "bad car";
      }
    }

    public int Resale()
    {
      if (_year < 1979) {
        return 800;
      } else {
        return 1000;
      }
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price <= maxPrice);
    }
  }

}