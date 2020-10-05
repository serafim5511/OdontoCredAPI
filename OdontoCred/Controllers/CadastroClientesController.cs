using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OdontoCred.Data;
using OdontoCred.Models;

namespace OdontoCred.Controllers
{
    public class CadastroClientesController : Controller
    {
        private readonly OdontoCredContext _context;

        public CadastroClientesController(OdontoCredContext context)
        {
            _context = context;
        }

        // GET: CadastroCliente
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: CadastroCliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroCliente = await _context.CadastroCliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroCliente == null)
            {
                return NotFound();
            }

            return View(cadastroCliente);
        }

        // GET: CadastroCliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroCliente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeCliente,EmailCliente,SenhaCliente")] CadastroCliente cadastroCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroCliente);
        }

        // GET: CadastroCliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroCliente = await _context.CadastroCliente.FindAsync(id);
            if (cadastroCliente == null)
            {
                return NotFound();
            }
            return View(cadastroCliente);
        }

        // POST: CadastroCliente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeCliente,EmailCliente,SenhaCliente")] CadastroCliente cadastroCliente)
        {
            if (id != cadastroCliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroClienteExists(cadastroCliente.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroCliente);
        }

        // GET: CadastroCliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroCliente = await _context.CadastroCliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroCliente == null)
            {
                return NotFound();
            }

            return View(cadastroCliente);
        }

        // POST: CadastroCliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cadastroCliente = await _context.CadastroCliente.FindAsync(id);
            _context.CadastroCliente.Remove(cadastroCliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroClienteExists(int id)
        {
            return _context.CadastroCliente.Any(e => e.Id == id);
        }
    }
}
