using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskPlanner.API.Data;
using TaskPlanner.API.Models;

namespace TaskPlanner.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private readonly DataContext _context;

        public TareasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Tarea>>> GetTareas()
        {
            return await _context.Tareas.Include(t => t.Categoria).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Tarea>> CrearTarea(Tarea nuevaTarea)
        {
            _context.Tareas.Add(nuevaTarea);
            await _context.SaveChangesAsync();

            return Ok(nuevaTarea);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarTarea(int id)
        {
            var tarea = await _context.Tareas.FindAsync(id);
            if (tarea == null) 
            {
                return NotFound();
            }
                
            _context.Tareas.Remove(tarea);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> EditarTarea(int id, Tarea tareaActualizada)
        {
            if (id != tareaActualizada.Id)
            {
                return BadRequest("El ID no coincide");
            }

            _context.Entry(tareaActualizada).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
