using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using backend_challenge.Data;

namespace backend_challenge.Controllers
{   
    [ApiController]
    [Route("empregados")]
    public class EmpregadoController : Controller
    {
        private readonly AppDbContext _context;

        public EmpregadoController(AppDbContext context)
        {
            _context = context;
        }

        // GET /empregados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empregado>>> GetEmpregados()
        {
            return await _context.Empregados.ToListAsync();
        }

        // GET /empregados/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Empregado>> GetEmpregado(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empregado = await _context.Empregados
                .FirstOrDefaultAsync(m => m.id_empregado == id);
            if (empregado == null)
            {
                return NotFound();
            }

            return empregado;
        }

        
        // POST /empregados
        [HttpPost]
        public async Task<ActionResult<Empregado>> PostEmpregado(Empregado empregado)
        {
           
            _context.Add(empregado);
            await _context.SaveChangesAsync();
                
            return empregado;
        }

        
        // PUT /empregados/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpregado(int id, Empregado empregado)
        {
            if (id != empregado.id_empregado)
            {
                return NotFound();
            }

            _context.Entry(empregado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!EmpregadoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();

        }
        
         //DELETE /Empregado/{id}
         [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpregado(int? id)
        {
            var empregado = await _context.Empregados.FindAsync(id);
            if(empregado == null)
            {
                return NotFound();
            }

            _context.Empregados.Remove(empregado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        
        private bool EmpregadoExists(int id)
        {
            return _context.Empregados.Any(e => e.id_empregado == id);
        }
        
    }
}
