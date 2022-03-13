using Domain.VehicleWarehouse.Abstractions.Service;
using Domain.VehicleWarehouse.Api.Mappers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Api
{
    [EnableCors("Default")]
    [Route("api/warehouse")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseService _warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _warehouseService.GetAllAsync();
            return Ok(result.Select(x => WarehouseMapper.ToDto(x)));
        }
    }
}
