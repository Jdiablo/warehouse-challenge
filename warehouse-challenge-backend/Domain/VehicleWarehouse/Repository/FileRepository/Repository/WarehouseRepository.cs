using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Abstractions.Repository;
using Domain.VehicleWarehouse.FileRepository.Mappers;
using Domain.VehicleWarehouse.FileRepository.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.FileRepository.Repository
{
    /// <summary>
    /// Warehouse repository to retrieve data from JSON file
    /// </summary>
    public class WarehouseRepository : IWarehouseRepository
    {
        private readonly string _filePath;

        public WarehouseRepository(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException();

            _filePath = filePath;
        }

        private async Task<string> GetFileDataAsync()
        {
            return await File.ReadAllTextAsync(_filePath);
        }

        public async Task<IEnumerable<Warehouse>> GetAllAsync()
        {
            var fileData = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<WarehouseDTO>>(await GetFileDataAsync());
            return WarehouseMapper.FromDTO(fileData);
        }

        public Task<Warehouse> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
