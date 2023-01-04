using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenQuynhAnh056.Models;

namespace NguyenQuynhAnh056.Controllers
{
    public class CompanyNQA056Controller : Controller
    {
        private readonly AplicationDbContext _context;

        public CompanyNQA056Controller(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: CompanyNQA056
        public async Task<IActionResult> Index()
        {
              return _context.CompanyNQA056 != null ? 
                          View(await _context.CompanyNQA056.ToListAsync()) :
                          Problem("Entity set 'AplicationDbContext.CompanyNQA056'  is null.");
        }

        // GET: CompanyNQA056/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CompanyNQA056 == null)
            {
                return NotFound();
            }

            var companyNQA056 = await _context.CompanyNQA056
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNQA056 == null)
            {
                return NotFound();
            }

            return View(companyNQA056);
        }

        // GET: CompanyNQA056/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyNQA056/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyNQA056 companyNQA056)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyNQA056);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyNQA056);
        }

        // GET: CompanyNQA056/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CompanyNQA056 == null)
            {
                return NotFound();
            }

            var companyNQA056 = await _context.CompanyNQA056.FindAsync(id);
            if (companyNQA056 == null)
            {
                return NotFound();
            }
            return View(companyNQA056);
        }

        // POST: CompanyNQA056/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyNQA056 companyNQA056)
        {
            if (id != companyNQA056.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyNQA056);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyNQA056Exists(companyNQA056.CompanyId))
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
            return View(companyNQA056);
        }

        // GET: CompanyNQA056/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CompanyNQA056 == null)
            {
                return NotFound();
            }

            var companyNQA056 = await _context.CompanyNQA056
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNQA056 == null)
            {
                return NotFound();
            }

            return View(companyNQA056);
        }

        // POST: CompanyNQA056/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CompanyNQA056 == null)
            {
                return Problem("Entity set 'AplicationDbContext.CompanyNQA056'  is null.");
            }
            var companyNQA056 = await _context.CompanyNQA056.FindAsync(id);
            if (companyNQA056 != null)
            {
                _context.CompanyNQA056.Remove(companyNQA056);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyNQA056Exists(string id)
        {
          return (_context.CompanyNQA056?.Any(e => e.CompanyId == id)).GetValueOrDefault();
        }
    }
}
