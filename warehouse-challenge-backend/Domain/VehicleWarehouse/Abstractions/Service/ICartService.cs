using Domain.VehicleWarehouse.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Abstractions.Service
{
    public interface ICartService
    {
        Task AddItemToCartAsync(int cartItem);
    }
}
