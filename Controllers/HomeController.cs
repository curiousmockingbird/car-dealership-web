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
      //Car yugo = new Car ("Yugo Koral 1978", 40587, 097532, 39, 1978);
      return View(allCars);
    }
  }
}