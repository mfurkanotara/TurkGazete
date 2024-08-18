using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TurkGazete.Models;

namespace TurkGazete.Controllers;

public class HaberController : Controller
{
    private readonly ILogger<HaberController> _logger;

   public IActionResult Index()
   {
    return View();
   }
   
   public IActionResult TekirdagHaber()
    {
        return View();
    }
    
    public IActionResult BesiktasYangin()
    {
        return View();
    }
    
    public IActionResult SurucuCeza()
    {
        return View();
    }

    public IActionResult TarimYapayZeka()
    {
        return View();
    }
}
