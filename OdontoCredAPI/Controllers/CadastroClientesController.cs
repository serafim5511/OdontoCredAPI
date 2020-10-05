using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OdontoCred.Models;

namespace OdontoCredAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize()]
    public class CadastroClientesController : ControllerBase
    {
        private readonly Context _context;

        public CadastroClientesController(Context context)
        {
            _context = context;
        }

        // GET: api/CadastroClientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CadastroCliente>>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        // GET: api/CadastroClientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CadastroCliente>> GetCadastroCliente(int id)
        {
            var cadastroCliente = await _context.Clientes.FindAsync(id);

            if (cadastroCliente == null)
            {
                return NotFound();
            }

            return cadastroCliente;
        }

        // PUT: api/CadastroClientes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCadastroCliente(int id, CadastroCliente cadastroCliente)
        {
            if (id != cadastroCliente.Id)
            {
                return BadRequest();
            }

            _context.Entry(cadastroCliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CadastroClienteExists(id))
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

        // POST: api/CadastroClientes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CadastroCliente>> PostCadastroCliente(CadastroCliente cadastroCliente)
        {
            _context.Clientes.Add(cadastroCliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCadastroCliente", new { id = cadastroCliente.Id }, cadastroCliente);
        }

        // DELETE: api/CadastroClientes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CadastroCliente>> DeleteCadastroCliente(int id)
        {
            var cadastroCliente = await _context.Clientes.FindAsync(id);
            if (cadastroCliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cadastroCliente);
            await _context.SaveChangesAsync();

            return cadastroCliente;
        }

        private bool CadastroClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
