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
    public class PatientCheckFeesController : Controller
    {
        private readonly DentalClinicContext _context;

        public PatientCheckFeesController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dentalClinicContext = _context.PatientCheckFee.Include(p => p.FeeElement).Include(p => p.PatientRegisterationCheck);
            return View(await dentalClinicContext.ToListAsync());
        }

        public IActionResult AddOrEdit(int id=0)
        {
            ViewData["FeeElementId"] = new SelectList(_context.FeeElement, "FeeElementId", "Name");
            ViewData["PatientRegisterationCheckId"] = new SelectList(_context.PatientRegisterationCheck, "PatientRegisterationCheckId", "Name");
            if (id == 0)
                return View(new PatientCheckFee());
            else
                return View(_context.PatientCheckFee.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("PatientCheckFeeId,FeeElementId,Fee,PatientRegisterationCheckId")] PatientCheckFee patientCheckFee)
        {
            if (ModelState.IsValid)
            {
                if (patientCheckFee.PatientCheckFeeId == 0)
                    _context.Add(patientCheckFee);
                else
                    _context.Update(patientCheckFee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FeeElementId"] = new SelectList(_context.FeeElement, "FeeElementId", "FeeElementId", patientCheckFee.FeeElementId);
            ViewData["PatientRegisterationCheckId"] = new SelectList(_context.PatientRegisterationCheck, "PatientRegisterationCheckId", "PatientRegisterationCheckId", patientCheckFee.PatientRegisterationCheckId);
            return View(patientCheckFee);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var patientCheckFee = await _context.PatientCheckFee.FindAsync(id);
            _context.PatientCheckFee.Remove(patientCheckFee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
