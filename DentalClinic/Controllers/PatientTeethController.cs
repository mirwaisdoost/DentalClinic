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
    public class PatientTeethController : Controller
    {
        private readonly DentalClinicContext _context;

        public PatientTeethController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dentalClinicContext = _context.PatientTeeth.Include(p => p.PatientRegisteration).Include(p => p.TeethNumber);
            return View(await dentalClinicContext.ToListAsync());
        }
        public IActionResult AddOrEdit(int id=0 )
        {
            ViewData["PatientRegisterationId"] = new SelectList(_context.PatientRegisteration, "PatientRegisterationId", "PatientRegisterationId");
            ViewData["TeethNumberId"] = new SelectList(_context.TeethNumber, "TeethNumberId", "TeethNumberId");
            if (id == 0)
                return View(new PatientTeeth());
            else
                return View(_context.PatientTeeth.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("PatientTeethId,PatientRegisterationId,TeethNumberId")] PatientTeeth patientTeeth)
        {
            if (ModelState.IsValid)
            {
                if (patientTeeth.PatientTeethId == 0)
                    _context.Add(patientTeeth);
                else
                    _context.Update(patientTeeth);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PatientRegisterationId"] = new SelectList(_context.PatientRegisteration, "PatientRegisterationId", "PatientRegisterationId", patientTeeth.PatientRegisterationId);
            ViewData["TeethNumberId"] = new SelectList(_context.TeethNumber, "TeethNumberId", "TeethNumberId", patientTeeth.TeethNumberId);
            return View(patientTeeth);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var patientTeeth = await _context.PatientTeeth.FindAsync(id);
            _context.PatientTeeth.Remove(patientTeeth);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
