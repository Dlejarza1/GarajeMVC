using GarajeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace GarajeMVC.Controllers
{
    public class HomeController : Controller
    {
        public Garage miGaraje;
        public HomeController()
        {
            // Instanciar el objeto miGaraje
            miGaraje = new Garage(1, "David Antonio Lejarza", 50, 0);
        }

        public IActionResult Index()
        { // Crea e ingresa el primer auto
     
        Auto auto1 = new Auto(1, "Toyota", "ABC-123");
        miGaraje.ingresarAuto(auto1);
         Auto auto2 = new Auto(2, "Honda", "DEF-456"); 
        miGaraje.ingresarAuto(auto2);
         Auto auto3 = new Auto(3, "Nissan","GHI-789"); 
        miGaraje.ingresarAuto(auto3);
            
        return View(miGaraje);

        }
    }

}

