using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DentalClinic.Models;

namespace DentalClinic.Controlls
{
    public class PatientHistoriesController : Controller
    {
        private readonly DentalClinicContext _context;

        public PatientHistoriesController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dentalClinicContext = _context.PatientHistory.Include(p => p.HistoryElement).Include(p => p.PatientRegisteration);
            return View(await dentalClinicContext.ToListAsync());
        }

        public IActionResult AddOrEdit(int id=0)
        {
            ViewData["HistoryElementId"] = new SelectList(_context.HistoryElement, "HistoryElementId", "HistoryElementId");
            ViewData["PatientRegisterationId"] = new SelectList(_context.PatientRegisteration, "PatientRegisterationId", "PatientRegisterationId");
            if (id == 0)
                return View(new PatientHistory());
            else
                return View(_context.PatientHistory.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("PatientHistoryId,PatientRegisterationId,HistoryElementId,Status,Description")] PatientHistory patientHistory)
        {
            if (ModelState.IsValid)
            {
                if (patientHistory.PatientHistoryId == 0)
                    _context.Add(patientHistory);
                else
                    _context.Update(patientHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HistoryElementId"] = new SelectList(_context.HistoryElement, "HistoryElementId", "HistoryElementId", patientHistory.HistoryElementId);
            ViewData["PatientRegisterationId"] = new SelectList(_context.PatientRegisteration, "PatientRegisterationId", "PatientRegisterationId", patientHistory.PatientRegisterationId);
            return View(patientHistory);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var patientHistory = await _context.PatientHistory.FindAsync(id);
            _context.PatientHistory.Remove(patientHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
