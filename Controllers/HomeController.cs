using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      Car volkswagen = new Car("Volkswagen Thing", 1100, 368792, 80, 1974);
      Car yugo = new Car ("Yugo Koral 1978", 40587, 097532, 39, 1978);
      Car ford = new Car("Ford Country Squire", 1400, 239001, 100, 1988);
      Car amc = new Car("AMC Pacer", 900, 198000, 40, 1976);

      return View(allCars);
    }
  }
}