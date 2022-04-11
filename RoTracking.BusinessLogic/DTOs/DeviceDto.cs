using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.BusinessLogic.DTOs
{
    public class DeviceDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime Release { get; set; }
        public DateTime AddingDate { get; set; }
        public string VehicleId { get; set; }
        public string DriverId { get; set; }
    }
}
