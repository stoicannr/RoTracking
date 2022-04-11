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
    public class VehicleService : IVehicleService
    {

        private readonly IVehicleRepository _vehicleRepository;
        private readonly ILogger _logger;
        public VehicleService(IVehicleRepository vehicleRepository, ILogger logger)
        {
            _vehicleRepository = vehicleRepository;
            _logger = logger;
        }

        public async Task<VehicleDto> CreateVehicle(VehicleDto vehicleDto)
        {
            try
            {
                if (vehicleDto is not null)
                {
                    var vehicle = new Vehicle { Id = Guid.NewGuid(), Code = vehicleDto.Code, Color = vehicleDto.Color, Mileage = vehicleDto.Mileage, Name = vehicleDto.Name }
                    _vehicleRepository.Add(vehicle);
                    _vehicleRepository.Save();
                    var createdVehicle = new VehicleDto(vehicle);
                    return createdVehicle;
                }

            }
            catch (Exception e)
            {
                _logger.LogError("There is an error");
            }
            return new VehicleDto();
        }

        public async Task<bool> DeleteVehicle(VehicleDto vehicleDto)
        {
            try
            {
                if(vehicleDto is not null)
                {
                    _vehicleRepository.Remove(vehicleDto.Id);
                    _vehicleRepository.Save();
                    return true;
                }
            }
            catch (Exception e)
            {
                _logger.LogError("There is an error");
            }
            return false;
        }

        public async Task<VehicleDto> UpdateVehicle(VehicleDto vehicleDto)
        {
            try
            {
                if (vehicleDto is not null)
                {
                    var updatedVehicle = _vehicleRepository.Get(vehicleDto.Id);
                    _vehicleRepository.Update(updatedVehicle);
                    _vehicleRepository.Save();
                    return new VehicleDto(updatedVehicle);
                }
            }
            catch (Exception e)
            {
                _logger.LogError("There is an error");
            }
            return new VehicleDto();
        }
    }
}
