using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/Cars")]
    public ActionResult Index()
    {
      List<Car> AllCars = Car.GetAll();
      return View(AllCars);
    }
    [HttpGet("/Cars/new")]
    public ActionResult CreateForms()
    {
      return View();
    }
    [HttpPost("/Cars")]
    public ActionResult Create(string makeModel, int miles, int price)
    {
      Car myCars = new Car(makeModel, price, miles);
      return RedirectToAction("Index");
    }
  }
}