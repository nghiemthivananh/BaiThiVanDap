using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NghiemThiVanAnh078.Data;
using NghiemThiVanAnh078.Models;

namespace NghiemThiVanAnh078.Controllers
{
    public class NTVA078Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public NTVA078Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NTVA078
        public async Task<IActionResult> Index()
        {
            return View(await _context.NTVA078.ToListAsync());
        }

        // GET: NTVA078/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTVA078 = await _context.NTVA078
                .FirstOrDefaultAsync(m => m.Masinhvien == id);
            if (nTVA078 == null)
            {
                return NotFound();
            }

            return View(nTVA078);
        }

        // GET: NTVA078/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTVA078/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Masinhvien,Tuoi,Diem")] NTVA078 nTVA078)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTVA078);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTVA078);
        }

        // GET: NTVA078/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTVA078 = await _context.NTVA078.FindAsync(id);
            if (nTVA078 == null)
            {
                return NotFound();
            }
            return View(nTVA078);
        }

        // POST: NTVA078/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Masinhvien,Tuoi,Diem")] NTVA078 nTVA078)
        {
            if (id != nTVA078.Masinhvien)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTVA078);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTVA078Exists(nTVA078.Masinhvien))
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
            return View(nTVA078);
        }

        // GET: NTVA078/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTVA078 = await _context.NTVA078
                .FirstOrDefaultAsync(m => m.Masinhvien == id);
            if (nTVA078 == null)
            {
                return NotFound();
            }

            return View(nTVA078);
        }

        // POST: NTVA078/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var nTVA078 = await _context.NTVA078.FindAsync(id);
            if (nTVA078 != null)
            {
                _context.NTVA078.Remove(nTVA078);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTVA078Exists(string id)
        {
            return _context.NTVA078.Any(e => e.Masinhvien == id);
        }
    }
}
