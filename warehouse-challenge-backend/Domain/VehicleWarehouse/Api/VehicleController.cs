using Domain.VehicleWarehouse.Abstractions.Service;
using Domain.VehicleWarehouse.Api.Mappers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Api
{
    [EnableCors("Default")]
    [Route("api/vehicle")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _vehicleService.GetAsync(id);
            if (result == null)
                return BadRequest();

            return Ok(VehicleMapper.ToFullDto(result));
        }
    }
}
