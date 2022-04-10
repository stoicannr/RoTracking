using Microsoft.EntityFrameworkCore;
using RoTracking.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.DataLayer.Context
{
    public class RoTrackingDbContext : DbContext
    {
        public RoTrackingDbContext(DbContextOptions<RoTrackingDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<DriverVehicleConnection> DriverVehicleConnection { get; set; }
        public DbSet<DeviceDriverConnection> DeviceDriverConnections { get; set; }
        public DbSet<DeviceVehicleConnection> DeviceVehicleConnection { get; set; }






    }
}
