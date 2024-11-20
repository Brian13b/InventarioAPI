using InventarioApp.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventarioApp.Services
{
    public interface IProductoService
    {
        Task<IEnumerable<ProductoDto>> GetProductosAsync();
        Task<ProductoDto> GetProductoByIdAsync(int id);
        Task<ProductoDto> CreateProductoAsync(ProductoDto productoDto);
        Task UpdateProductoAsync(int id, ProductoDto productoDto);
        Task DeleteProductoAsync(int id);
    }
}

