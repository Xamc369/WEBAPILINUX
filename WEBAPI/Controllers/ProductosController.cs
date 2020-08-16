using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPI.Data;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ProductoContexto _context;

        public ProductosController(ProductoContexto contexto)
        {
            _context = contexto;
        }

        //metodo para listar 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productos>>> GetProductosItems()
        {
            return await _context.ProductosItems.ToListAsync();
        }

        //metodo para obtener un solo registro
        [HttpGet("{id}")]
        public async Task<ActionResult<Productos>> GetProductoItem(int id)
        {
            var productoItem = await _context.ProductosItems.FindAsync(id);

            if(productoItem == null)
            {
                return NotFound();
            }

            return productoItem;
        }

        //metodo para ingresar registros
        [HttpPost]
        public async Task<ActionResult<Productos>> PostProductoItem(Productos item)
        {
            _context.ProductosItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductoItem), new { id = item.IdProducto }, item);
        }

        //metodo por actualizar 
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductoItem(int id, Productos item)
        {
            if(id != item.IdProducto)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //metodo para eliminar
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductoItem(int id)
        {
            var productoItem = await _context.ProductosItems.FindAsync(id);

            if(productoItem == null)
            {
                return NotFound();
            }

            _context.ProductosItems.Remove(productoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
