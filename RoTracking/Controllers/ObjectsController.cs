using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoTracking.BusinessLogic.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoTracking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectsController : ControllerBase
    {
        private IVehicleService _vehicleService;

        public ObjectsController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }


    }
}
