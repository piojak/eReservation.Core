using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DTO.Models;
using Microsoft.AspNetCore.Mvc;
using eReservation.Models;

namespace eReservation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Reserve()
        {
            var asd = new List<Room>() { new Room() { Id = 1, Name = "Pokój nr 1" }, new Room() { Id = 2, Name = "Pokój nr 2" }, new Room() { Id = 3, Name = "Pokój nr 3" } };
            return View(asd);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
