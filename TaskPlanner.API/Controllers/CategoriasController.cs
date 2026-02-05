using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskPlanner.API.Data;
using Microsoft.EntityFrameworkCore;
using TaskPlanner.API.Models;

namespace TaskPlanner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoriasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> GetCategorias() 
        {
            return await _context.Categorias.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Categoria>> CrearCategoria(Categoria nuevaCategoria)
        {
            _context.Categorias.Add(nuevaCategoria);
            await _context.SaveChangesAsync();

            return Ok(nuevaCategoria);
        }
    }
}
