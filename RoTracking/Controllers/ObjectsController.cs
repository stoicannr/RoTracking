using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoTracking.BusinessLogic.DTOs;
using RoTracking.BusinessLogic.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoTracking.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ObjectsController : ControllerBase
    {
        private IVehicleService _vehicleService;

        public ObjectsController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("GetAllVehicles")]
        public async Task<IEnumerable<VehicleDto>> GetAllVehicles()
        {
            return await _vehicleService.GetAllVehicles();
        }

        [HttpPost("CreateVehicle")]
        public async Task<VehicleDto> CreateVehicle(VehicleDto vehicleDto)
        {
            return await _vehicleService.CreateVehicle(vehicleDto);
        }

        [HttpDelete("DeleteVehicle")]
        public async Task<bool> DeleteVehicle(VehicleDto vehicleDto)
        {
            return await _vehicleService.DeleteVehicle(vehicleDto);
        }

        [HttpPut("UpdateVehicle")]
        public async Task<VehicleDto> UpdateVehicle(VehicleDto vehicleDto)
        {
            return await _vehicleService.UpdateVehicle(vehicleDto);
        }

    }
}
