using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PracticaApp.Models;

namespace PracticaApp.Controllers
{
    public class RecepcionsController : Controller
    {
        private readonly PracticaAppContext _context;

        public RecepcionsController(PracticaAppContext context)
        {
            _context = context;
        }

        // GET: Recepcions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Recepcion.ToListAsync());
        }

        // GET: Recepcions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recepcion = await _context.Recepcion
                .SingleOrDefaultAsync(m => m.Id == id);
            if (recepcion == null)
            {
                return NotFound();
            }

            return View(recepcion);
        }

        // GET: Recepcions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recepcions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumLote,Proveedor,RutProveedor,PesoFruta")] Recepcion recepcion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recepcion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recepcion);
        }

        // GET: Recepcions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recepcion = await _context.Recepcion.SingleOrDefaultAsync(m => m.Id == id);
            if (recepcion == null)
            {
                return NotFound();
            }
            return View(recepcion);
        }

        // POST: Recepcions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumLote,Proveedor,RutProveedor,PesoFruta")] Recepcion recepcion)
        {
            if (id != recepcion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recepcion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecepcionExists(recepcion.Id))
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
            return View(recepcion);
        }

        // GET: Recepcions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recepcion = await _context.Recepcion
                .SingleOrDefaultAsync(m => m.Id == id);
            if (recepcion == null)
            {
                return NotFound();
            }

            return View(recepcion);
        }

        // POST: Recepcions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recepcion = await _context.Recepcion.SingleOrDefaultAsync(m => m.Id == id);
            _context.Recepcion.Remove(recepcion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecepcionExists(int id)
        {
            return _context.Recepcion.Any(e => e.Id == id);
        }
    }
}
