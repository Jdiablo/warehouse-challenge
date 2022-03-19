using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Abstractions.Service;
using Domain.VehicleWarehouse.Api.DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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

        [HttpGet("all")]
        public async Task<IActionResult> GetAllAsync()
        {
            var res = await _cartService.GetAllAsync();

            return Ok(res.Select(x => new CartItemDTO() { ItemId = x.VehicleId}));
        }

        [HttpPost("{vehicleId}")]
        public async Task<IActionResult> AddItemToCart(int vehicleId)
        {
            await _cartService.AddItemToCartAsync(vehicleId);

            return Ok();
        }

        [HttpDelete("{vehicleId}")]
        public async Task<IActionResult> DeleteItemFromCart(int vehicleId)
        {
            await _cartService.DeleteAsync(vehicleId);

            return Ok();
        }
    }
}
