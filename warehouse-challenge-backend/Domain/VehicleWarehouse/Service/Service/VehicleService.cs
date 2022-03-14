using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Abstractions.Repository;
using Domain.VehicleWarehouse.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleVehicle.Services.Service
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _VehicleRepository;

        public VehicleService (IVehicleRepository VehicleRepository) : base()
        {
            _VehicleRepository = VehicleRepository;
        }

        public async Task<IEnumerable<Vehicle>> GetAllAsync()
        {
           return await _VehicleRepository.GetAllAsync();
        }

        public async Task<Vehicle> GetAsync(object id)
        {
            int idInt = (int)id;
            return await _VehicleRepository.GetAsync(x => x.Id == idInt && x.Licensed);
        }
    }
}
