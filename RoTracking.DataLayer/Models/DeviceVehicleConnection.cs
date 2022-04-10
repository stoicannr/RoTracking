using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.DataLayer.Models
{
    public class DeviceVehicleConnection
    {
        public Guid Id { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual Device Device { get; set; }
        public DateTime ConnectionStartDate { get; set; }
        public DateTime ConnectionEndDate { get; set; }
    }
}
