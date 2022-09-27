using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dealership.Models;

namespace Cars.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Cars()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles, int topSpeed, int year)
    {
      Car newCar = new Car(makeModel, price, miles, topSpeed, year);
      return RedirectToAction("Cars");
    }
  }
}