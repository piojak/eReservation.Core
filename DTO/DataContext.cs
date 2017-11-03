using System;
using DTO.Model;
using Microsoft.EntityFrameworkCore;

namespace DTO
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Room> Rooms { get; set; }
    }
}

