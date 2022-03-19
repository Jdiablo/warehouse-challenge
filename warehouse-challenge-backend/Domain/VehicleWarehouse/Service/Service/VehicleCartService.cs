using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Abstractions.Repository;
using Domain.VehicleWarehouse.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Services.Service
{
    public class VehicleCartService : ICartService
    {
        private readonly IVehicleCartRepository _vehicleCartRepository;

        public VehicleCartService(IVehicleCartRepository vehicleCartRepository)
        {
            _vehicleCartRepository = vehicleCartRepository;
        }

        public async Task AddItemToCartAsync(int cartItemId)
        {
            await _vehicleCartRepository.AddAsync(new VehicleCartItem()
            { 
                VehicleId = cartItemId
            });
        }
    }
}
