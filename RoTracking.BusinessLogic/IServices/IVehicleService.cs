using RoTracking.BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.BusinessLogic.IServices
{
    public interface IVehicleService
    {
        Task<VehicleDto> CreateVehicle(VehicleDto vehicleDto);
        Task<VehicleDto> UpdateVehicle(VehicleDto vehicleDto);
        Task<IEnumerable<VehicleDto>> GetAllVehicles();
        Task<bool> DeleteVehicle(VehicleDto vehicleDto);
    }
}
