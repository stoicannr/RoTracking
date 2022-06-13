using RoTracking.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.BusinessLogic.DTOs
{
    public class DeviceDto
    {
        public Guid id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public DateTime release { get; set; }
        public DateTime created { get; set; }
        public VehicleDto vehicle { get; set; }
        public PersonDto driver { get; set; }
        public string brand { get; set; }

        public DeviceDto()
        {

        }

        public DeviceDto(Device device)
        {
            id = device.Id;
            code = device.Code;
            name = device.Name;
            release = device.Release;
            created = device.AddingDate;
            brand = device.Brand;
        }
    }
}
