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
    public class DevicesController : ControllerBase
    {

        private IDeviceService _deviceService;

        public DevicesController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpGet("GetAllDevices")]
        public async Task<IEnumerable<DeviceDto>> GetAllDevices()
        {
            return await _deviceService.GetAllDevices();
        }

        [HttpPost("CreateDevice")]
        public async Task<DeviceDto> CreateDevice(DeviceDto deviceDto)
        {
            return await _deviceService.CreateDevice(deviceDto);
        }

        [HttpDelete("DeleteDevice")]
        public async Task<bool> DeleteDevice(DeviceDto deviceDto)
        {
            return await _deviceService.DeleteDevice(deviceDto);
        }

        [HttpPut("UpdateDevice")]
        public async Task<DeviceDto> UpdateDevice(DeviceDto deviceDto)
        {
            return await _deviceService.UpdateDevice(deviceDto);
        }
    }
}
