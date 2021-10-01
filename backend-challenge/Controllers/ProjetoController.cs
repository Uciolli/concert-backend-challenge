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
    [Route("projetos")]
    public class ProjetoController : Controller
    {
        private readonly AppDbContext _context;

        public ProjetoController(AppDbContext context)
        {
            _context = context;
        }

        // GET /projetos   
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Projeto>>> GetProjetos()
        {
            return await _context.Projetos.ToListAsync();
        }

        // GET /projetos/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Projeto>> GetProjeto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projeto = await _context.Projetos
                .FirstOrDefaultAsync(m => m.id_projeto == id);
            if (projeto == null)
            {
                return NotFound();
            }

            return projeto;
        }

        
        // POST /projetos
        [HttpPost]
        public async Task<ActionResult<Projeto>> Postprojeto(Projeto projeto)
        {
           
            _context.Add(projeto);
            await _context.SaveChangesAsync();
                
            return projeto;
        }

        
        // PUT /projetos/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjeto(int id, Projeto projeto)
        {
            if (id != projeto.id_projeto)
            {
                return NotFound();
            }

            _context.Entry(projeto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!ProjetoExists(id))
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
        
         //DELETE /projeto/{id}
         [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjeto(int? id)
        {
            var projeto = await _context.Projetos.FindAsync(id);
            if(projeto == null)
            {
                return NotFound();
            }

            _context.Projetos.Remove(projeto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        
        private bool ProjetoExists(int id)
        {
            return _context.Projetos.Any(e => e.id_projeto == id);
        }
        
    }
}
