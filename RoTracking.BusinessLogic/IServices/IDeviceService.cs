using RoTracking.BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.BusinessLogic.IServices
{
    public interface IDeviceService
    {
        Task<DeviceDto> CreateDevice(DeviceDto deviceDto);

        Task<DeviceDto> UpdateDevice(DeviceDto deviceDto);

        Task<bool> DeleteDevice(DeviceDto deviceDto);
    }
}
