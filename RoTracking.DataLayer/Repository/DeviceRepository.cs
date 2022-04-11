using RoTracking.DataLayer.Context;
using RoTracking.DataLayer.IRepository;
using RoTracking.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.DataLayer.Repository
{
    public class DeviceRepository:BaseRepository<Device>,IDeviceRepository
    {
        public DeviceRepository(RoTrackingDbContext roTrackingDbContext) : base(roTrackingDbContext)
        {

        }
    }
}
