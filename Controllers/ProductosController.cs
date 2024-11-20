using Microsoft.AspNetCore.Mvc;
using InventarioApp.DTOs;
using InventarioApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using InventarioApp.Models;

namespace InventarioApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductoDto>>> GetProductos()
        {
            return Ok(await _productoService.GetProductosAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductoDto>> GetProducto(int id)
        {
            var producto = await _productoService.GetProductoByIdAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        [HttpPost]
        public async Task<ActionResult<ProductoDto>> PostProducto(ProductoDto productoDto)
        {
            var productoCreado = await _productoService.CreateProductoAsync(productoDto);
            return CreatedAtAction(nameof(GetProducto), new { id = productoCreado.Id }, productoCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, ProductoDto productoDto)
        {
            await _productoService.UpdateProductoAsync(id, productoDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            await _productoService.DeleteProductoAsync(id);
            return NoContent();
        }
    }
}

