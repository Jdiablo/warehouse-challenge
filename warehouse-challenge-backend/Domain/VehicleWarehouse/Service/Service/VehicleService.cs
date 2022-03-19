using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Abstractions.Repository;
using Domain.VehicleWarehouse.Abstractions.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.VehicleVehicle.Services.Service
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService (IVehicleRepository VehicleRepository) : base()
        {
            _vehicleRepository = VehicleRepository;
        }

        public async Task<IEnumerable<Vehicle>> GetAllAsync()
        {
           return await _vehicleRepository.GetAllAsync();
        }

        public async Task<Vehicle> GetAsync(object id)
        {
            int idInt = (int)id;
            return await _vehicleRepository.GetAsync(x => x.Id == idInt && x.Licensed);
        }
    }
}
