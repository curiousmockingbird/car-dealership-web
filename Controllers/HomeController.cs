using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Home.Controllers
{
  public class HomeController : Controller
  {
    
    [HttpGet("/")]
    public ActionResult Index()
    {
      Car.ClearAll();

      Car volkswagen = new Car("Volkswagen Thing", 1100, 368792, 80, 1974);
      Car yugo = new Car ("Yugo Koral 1978", 40587, 097532, 39, 1978);
      Car ford = new Car("Ford Country Squire", 1400, 239001, 100, 1988);
      Car amc = new Car("AMC Pacer", 900, 198000, 40, 1976);
      
      List<Car> allCars = Car.GetAll();
      // List<NewCar> allNewCars = NewCar.GetAllNew();
      return View(allCars);
    }
  }
}