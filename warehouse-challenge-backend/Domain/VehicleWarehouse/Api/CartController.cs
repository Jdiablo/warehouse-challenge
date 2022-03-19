using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Abstractions.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Api
{
    [EnableCors("Default")]
    [Route("api/cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("items/add/{vehicleId}")]
        public async Task<IActionResult> AddItemToCart(int vehicleId)
        {
            await _cartService.AddItemToCartAsync(vehicleId);

            return Ok();
        }
    }
}
