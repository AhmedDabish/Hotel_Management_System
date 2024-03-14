using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class dbcontext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .;Database = Hotel_Management_System ; Trusted_connection = true ; Encrypt = false");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Client> clients { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Reservation> reservations { get; set; }
        public DbSet<Admin> admins { get; set; }
    }
}
