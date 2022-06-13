using RoTracking.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.BusinessLogic.DTOs
{
    public class VehicleDto
    {
        public Guid id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string deviceId { get; set; }
        public DeviceDto device { get; set; }
        public PersonDto driver { get; set; }
        public decimal mileage { get; set; }
        public string color { get; set; }
        public string brand  { get; set; }
        public string  model { get; set; }
        public VehicleDto()
        {

        }
        public VehicleDto(Vehicle vehicle)
        {
            code = vehicle.Code;
            name = vehicle.Name;
            color = vehicle.Color;
            mileage = vehicle.Mileage;
            id = vehicle.Id;
        }

    }
}
