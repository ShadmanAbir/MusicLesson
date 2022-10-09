using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicLesson.Models;

namespace MusicLesson.Controllers
{
    public class LettersController : Controller
    {
        private readonly MusicLessonsDBContext _context;

        public LettersController(MusicLessonsDBContext context)
        {
            _context = context;
        }

        // GET: Letters
        public async Task<IActionResult> Index()
        {
              return View(await _context.Letters.ToListAsync());
        }

        // GET: Letters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Letters == null)
            {
                return NotFound();
            }

            var letters = await _context.Letters
                .FirstOrDefaultAsync(m => m.LetterID == id);
            if (letters == null)
            {
                return NotFound();
            }

            return View(letters);
        }

        // GET: Letters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Letters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LetterID,Reference,PaymentStatus,BeginningComment,Signature,BankAccount,BSB,AccountNo,Term,Semester,Year,TermStartDate,TotalCost")] Letters letters)
        {
            if (ModelState.IsValid)
            {
                _context.Add(letters);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(letters);
        }

        // GET: Letters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Letters == null)
            {
                return NotFound();
            }

            var letters = await _context.Letters.FindAsync(id);
            if (letters == null)
            {
                return NotFound();
            }
            return View(letters);
        }

        // POST: Letters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LetterID,Reference,PaymentStatus,BeginningComment,Signature,BankAccount,BSB,AccountNo,Term,Semester,Year,TermStartDate,TotalCost")] Letters letters)
        {
            if (id != letters.LetterID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(letters);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LettersExists(letters.LetterID))
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
            return View(letters);
        }

        // GET: Letters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Letters == null)
            {
                return NotFound();
            }

            var letters = await _context.Letters
                .FirstOrDefaultAsync(m => m.LetterID == id);
            if (letters == null)
            {
                return NotFound();
            }

            return View(letters);
        }

        // POST: Letters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Letters == null)
            {
                return Problem("Entity set 'MusicLessonsDBContext.Letters'  is null.");
            }
            var letters = await _context.Letters.FindAsync(id);
            if (letters != null)
            {
                _context.Letters.Remove(letters);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LettersExists(int id)
        {
          return _context.Letters.Any(e => e.LetterID == id);
        }
    }
}
