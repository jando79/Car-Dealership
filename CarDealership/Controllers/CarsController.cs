using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    
    [HttpGet("/cars/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/cars/carpage")]
    public ActionResult CarPage(string description, string carPrice)
    {
      Cars myCars = new Cars(description, carPrice);
      return View(myCars);
    }
  }
}