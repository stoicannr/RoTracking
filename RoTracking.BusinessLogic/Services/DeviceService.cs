using Microsoft.Extensions.Logging;
using RoTracking.BusinessLogic.DTOs;
using RoTracking.BusinessLogic.IServices;
using RoTracking.DataLayer.IRepository;
using RoTracking.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.BusinessLogic.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;
        //private readonly ILogger _logger;
        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
            //_logger = logger;
        }

        public async Task<DeviceDto> CreateDevice(DeviceDto deviceDto)
        {
            try
            {
                if (deviceDto is not null)
                {
                    var device = new Device { Id = deviceDto.Id, AddingDate = deviceDto.AddingDate, Release = deviceDto.Release, Name = deviceDto.Name, Code = deviceDto.Name };
                    _deviceRepository.Add(device);
                    _deviceRepository.Save();
                    var createdDevice = new DeviceDto(device);
                    return createdDevice;
                }

            }
            catch (Exception e)
            {
                //_logger.LogError("There is an error");
            }
            return new DeviceDto();
        }

        public async Task<bool> DeleteDevice(DeviceDto deviceDto)
        {
            try
            {
                if (deviceDto is not null)
                {
                    _deviceRepository.Remove(deviceDto.Id);
                    _deviceRepository.Save();
                    return true;
                }
            }
            catch (Exception e)
            {
                //_logger.LogError("There is an error");
            }
            return false;
        }

        public async Task<DeviceDto> UpdateDevice(DeviceDto deviceDto)
        {
            try
            {
                if (deviceDto is not null)
                {
                    var updatedVehicle = _deviceRepository.Get(deviceDto.Id);
                    _deviceRepository.Update(updatedVehicle);
                    _deviceRepository.Save();
                    return new DeviceDto(updatedVehicle);
                }
            }
            catch (Exception e)
            {
                //_logger.LogError("There is an error");
            }
            return new DeviceDto();
        }

    }
}
