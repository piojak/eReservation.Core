using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DTO.Models
{
    public class Room
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Caption { get; set; }
        public string ImageUrl { get; set; }



        #region Methods

        public static List<Room> GetAllRooms()
        {
            List<Room> result;
            var opt = new DbContextOptionsBuilder<DataContext>();
            opt.UseSqlServer("Server=tcp:reservationserver.database.windows.net,1433;Initial Catalog=eReservation;Persist Security Info=False;User ID=Lemon;Password=Pistacja123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (var dc = new DataContext(opt.Options))
            {
                result = dc.Rooms.ToList();
            }
            return result;
        }

        #endregion
    }
}
