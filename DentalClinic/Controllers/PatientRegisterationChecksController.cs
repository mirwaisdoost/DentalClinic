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
    public class PatientRegisterationChecksController : Controller
    {
        private readonly DentalClinicContext _context;

        public PatientRegisterationChecksController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dentalClinicContext = _context.PatientRegisterationCheck.Include(p => p.PatientRegisteration);
            return View(await dentalClinicContext.ToListAsync());
        }
        public IActionResult AddOrEdit(int id=0)
        {
            ViewData["PatientRegisterationId"] = new SelectList(_context.PatientRegisteration, "PatientRegisterationId", "PatientRegisterationId");
            if (id == 0)
                return View(new PatientRegisterationCheck());
            else
                return View(_context.PatientRegisterationCheck.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("PatientRegisterationCheckId,CheckDate,PatientRegisterationId")] PatientRegisterationCheck patientRegisterationCheck)
        {
            if (ModelState.IsValid)
            {
                if (patientRegisterationCheck.PatientRegisterationCheckId == 0)
                    _context.Add(patientRegisterationCheck);
                else
                    _context.Update(patientRegisterationCheck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PatientRegisterationId"] = new SelectList(_context.PatientRegisteration, "PatientRegisterationId", "PatientRegisterationId", patientRegisterationCheck.PatientRegisterationId);
            return View(patientRegisterationCheck);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var patientRegisterationCheck = await _context.PatientRegisterationCheck.FindAsync(id);
            _context.PatientRegisterationCheck.Remove(patientRegisterationCheck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
