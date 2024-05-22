using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test02.Models;

namespace Test02.Controllers
{
    public class BesitzersController : Controller
    {
        private readonly FZContext _context;

        public BesitzersController(FZContext context)
        {
            _context = context;
        }

        // GET: Besitzers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Besitzer.ToListAsync());
        }

        // GET: Besitzers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var besitzer = await _context.Besitzer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (besitzer == null)
            {
                return NotFound();
            }

            return View(besitzer);
        }

        // GET: Besitzers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Besitzers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Vorname,Nachname,Geburtsdatum,Adresse,Telefonnummer,Email")] Besitzer besitzer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(besitzer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(besitzer);
        }

        // GET: Besitzers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var besitzer = await _context.Besitzer.FindAsync(id);
            if (besitzer == null)
            {
                return NotFound();
            }
            return View(besitzer);
        }

        // POST: Besitzers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Vorname,Nachname,Geburtsdatum,Adresse,Telefonnummer,Email")] Besitzer besitzer)
        {
            if (id != besitzer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(besitzer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BesitzerExists(besitzer.Id))
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
            return View(besitzer);
        }

        // GET: Besitzers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var besitzer = await _context.Besitzer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (besitzer == null)
            {
                return NotFound();
            }

            return View(besitzer);
        }

        // POST: Besitzers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var besitzer = await _context.Besitzer.FindAsync(id);
            if (besitzer != null)
            {
                _context.Besitzer.Remove(besitzer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BesitzerExists(string id)
        {
            return _context.Besitzer.Any(e => e.Id == id);
        }
    }
}
