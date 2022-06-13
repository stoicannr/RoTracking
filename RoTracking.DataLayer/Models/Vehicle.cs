using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.DataLayer.Models
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Mileage { get; set; }
        public string Brand { get; set; }
        public string  Model { get; set; }
        public string Color { get; set; }
    }
}
