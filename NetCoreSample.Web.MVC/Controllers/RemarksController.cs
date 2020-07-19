using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCoreSample.DAL.DAL;
using NetCoreSample.Models.Entities;

namespace NetCoreSample.Web.MVC.Controllers
{
    public class RemarksController : Controller
    {
        private readonly DataContext _context;

        public RemarksController(DataContext context)
        {
            _context = context;
        }

        // GET: Remarks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Remarks.ToListAsync());
        }

        // GET: Remarks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var remarks = await _context.Remarks
                .FirstOrDefaultAsync(m => m.RemarksId == id);
            if (remarks == null)
            {
                return NotFound();
            }

            return View(remarks);
        }

        // GET: Remarks/Create
        public IActionResult Create()
        {
            ViewBag.FkCursos = new SelectList(this._context.Courses, "CourseId", "ShortDescription");
            return View();
        }

        // POST: Remarks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RemarksId,FkCourseId,Description,Qualification,Status,Author,CreatedOn")] Remarks remarks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(remarks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(remarks);
        }

        // GET: Remarks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var remarks = await _context.Remarks.FindAsync(id);
            if (remarks == null)
            {
                return NotFound();
            }
            return View(remarks);
        }

        // POST: Remarks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RemarksId,FkCourseId,Description,Qualification,Status,Author,CreatedOn")] Remarks remarks)
        {
            if (id != remarks.RemarksId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(remarks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RemarksExists(remarks.RemarksId))
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
            return View(remarks);
        }

        // GET: Remarks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var remarks = await _context.Remarks
                .FirstOrDefaultAsync(m => m.RemarksId == id);
            if (remarks == null)
            {
                return NotFound();
            }

            return View(remarks);
        }

        // POST: Remarks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var remarks = await _context.Remarks.FindAsync(id);
            _context.Remarks.Remove(remarks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RemarksExists(int id)
        {
            return _context.Remarks.Any(e => e.RemarksId == id);
        }
    }
}
