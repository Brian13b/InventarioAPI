using AutoMapper;
using InventarioApp.Data;
using InventarioApp.DTOs;
using InventarioApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioApp.Services
{
    public class ProductoService : IProductoService
    {
        private readonly InventarioContext _context;
        private readonly IMapper _mapper;

        public ProductoService(InventarioContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductoDto>> GetProductosAsync()
        {
            var productos = await _context.Productos.ToListAsync();
            return _mapper.Map<IEnumerable<ProductoDto>>(productos);
        }

        public async Task<ProductoDto> GetProductoByIdAsync(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            return _mapper.Map<ProductoDto>(producto);
        }

        public async Task<ProductoDto> CreateProductoAsync(ProductoDto productoDto)
        {
            if (productoDto == null)
            {
                throw new ArgumentNullException(nameof(productoDto));
            }

            var producto = _mapper.Map<Producto>(productoDto);

            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            var productoCreado = _mapper.Map<ProductoDto>(producto);

            return productoCreado;
        }


        public async Task UpdateProductoAsync(int id, ProductoDto productoDto)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _mapper.Map(productoDto, producto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteProductoAsync(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
            }
        }
    }
}
