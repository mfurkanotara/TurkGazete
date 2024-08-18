using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TurkGazete.Models;

namespace TurkGazete.Controllers;

public class MenuController : Controller
{
    private readonly ILogger<MenuController> _logger;

   public IActionResult Hakkinda()
   {
    return View();
   }

   public IActionResult Blog()
   {
    return View();
   }

}
