using System;
using DTO.Models;
using eReservation.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DTO
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DataContext()
            : base()
        { }

        public DbSet<Room> Rooms { get; set; }
    }
}

