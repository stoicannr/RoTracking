using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.DataLayer.Models
{
    public class DeviceDriverConnection
    {
        public Guid Id { get; set; }
        public virtual Person Driver { get; set; }
        public virtual Device Device { get; set; }
        public DateTime ConnectionStartDate { get; set; }
        public DateTime ConnectionEndDate { get; set; }
    }
}
