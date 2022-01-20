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
    public class PatientRegisterationCheckDrugsController : Controller
    {
        private readonly DentalClinicContext _context;

        public PatientRegisterationCheckDrugsController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dentalClinicContext = _context.PatientRegisterationCheckDrug.Include(p => p.DrugElement).Include(p => p.PatientRegisterationCheck);
            return View(await dentalClinicContext.ToListAsync());
        }
        public IActionResult AddOrEdit(int id=0)
        {
            ViewData["DrugElementId"] = new SelectList(_context.DrugElement, "DrugElementId", "DrugElementId");
            ViewData["PatientRegisterationCheckId"] = new SelectList(_context.PatientRegisterationCheck, "PatientRegisterationCheckId", "PatientRegisterationCheckId");
            if (id == 0)
                return View(new PatientRegisterationCheckDrug());
            else
                return View(_context.PatientRegisterationCheckDrug.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("PatientRegisterationCheckDrugId,DrugElementId,PatientRegisterationCheckId,Price")] PatientRegisterationCheckDrug patientRegisterationCheckDrug)
        {
            if (ModelState.IsValid)
            {
                if (patientRegisterationCheckDrug.PatientRegisterationCheckDrugId == 0)
                    _context.Add(patientRegisterationCheckDrug);
                else
                    _context.Update(patientRegisterationCheckDrug);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DrugElementId"] = new SelectList(_context.DrugElement, "DrugElementId", "DrugElementId", patientRegisterationCheckDrug.DrugElementId);
            ViewData["PatientRegisterationCheckId"] = new SelectList(_context.PatientRegisterationCheck, "PatientRegisterationCheckId", "PatientRegisterationCheckId", patientRegisterationCheckDrug.PatientRegisterationCheckId);
            return View(patientRegisterationCheckDrug);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var patientRegisterationCheckDrug = await _context.PatientRegisterationCheckDrug.FindAsync(id);
            _context.PatientRegisterationCheckDrug.Remove(patientRegisterationCheckDrug);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
