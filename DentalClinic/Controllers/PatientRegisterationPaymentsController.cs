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
    public class PatientRegisterationPaymentsController : Controller
    {
        private readonly DentalClinicContext _context;

        public PatientRegisterationPaymentsController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dentalClinicContext = _context.PatientRegisterationPayment.Include(p => p.PatientRegisterationCheck);
            return View(await dentalClinicContext.ToListAsync());
        }

        public IActionResult AddOrEdit(int id=0)
        {
            ViewData["PatientRegisterationCheckId"] = new SelectList(_context.PatientRegisterationCheck, "PatientRegisterationCheckId", "PatientRegisterationCheckId");
            if (id == 0)
                return View(new PatientRegisterationPayment());
            else
                return View(_context.PatientRegisterationPayment.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("PatientRegisterationPaymentId,DrugTotal,FeeTotal,Payed,Date,PatientRegisterationCheckId")] PatientRegisterationPayment patientRegisterationPayment)
        {
            if (ModelState.IsValid)
            {
                if (patientRegisterationPayment.PatientRegisterationPaymentId == 0)
                    _context.Add(patientRegisterationPayment);
                else
                    _context.Update(patientRegisterationPayment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PatientRegisterationCheckId"] = new SelectList(_context.PatientRegisterationCheck, "PatientRegisterationCheckId", "PatientRegisterationCheckId", patientRegisterationPayment.PatientRegisterationCheckId);
            return View(patientRegisterationPayment);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var patientRegisterationPayment = await _context.PatientRegisterationPayment.FindAsync(id);
            _context.PatientRegisterationPayment.Remove(patientRegisterationPayment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
