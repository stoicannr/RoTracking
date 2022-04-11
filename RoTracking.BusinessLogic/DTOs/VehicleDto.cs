using RoTracking.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.BusinessLogic.DTOs
{
    public class ObjectDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DeviceId { get; set; }
        public string DriverId { get; set; }
        public decimal Mileage { get; set; }
        public string Color { get; set; }

        public ObjectDto ()
        {

        }
        public ObjectDto(Vehicle vehicle)
        {
            Code = vehicle.Code;
            Name = vehicle.Name;
            Color = vehicle.Color;
            Id = vehicle.Id;
        }

    }
}
