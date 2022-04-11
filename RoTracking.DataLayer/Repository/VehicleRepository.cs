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
    public class VehicleRepository:BaseRepository<Vehicle>,IVehicleRepository
    {

        public VehicleRepository(RoTrackingDbContext roTrackingDbContext) : base(roTrackingDbContext)
        {
            
        }
    }
}
