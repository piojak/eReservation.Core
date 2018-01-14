using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO.Models;
using Microsoft.AspNetCore.Mvc;

namespace eReservation.Extensions.Controllers
{
    public class ReservationController : Controller
    {

        public IActionResult SelectRoom()
        {
            var asd = Room.GetAllRooms();
            return View(asd);
        }
    }
}
