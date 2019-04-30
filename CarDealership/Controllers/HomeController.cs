using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Dealership.Models;

namespace Dealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
      // return ne w EmptyResult();
    }
  }
}
