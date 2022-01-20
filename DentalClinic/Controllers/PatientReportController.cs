using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalClinic.Models;
using DentalClinic.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class PatientReportController : Controller
    {
        private readonly DentalClinicContext _context;

        public PatientReportController(DentalClinicContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PatientReport(DateTime From, DateTime To)
        {
            var PatientReport = _context.PatientRegisterationCheck.Where(p =>
                                p.CheckDate >= From && p.CheckDate <= To).ToList();
            
            List<PatientRegistrationViewModel> PRVM = new List<PatientRegistrationViewModel>();
            foreach (var item in PatientReport)
            {
                var Payment = _context.PatientRegisterationPayment.Where(p => p.PatientRegisterationCheckId == item.PatientRegisterationCheckId);
                decimal? fee = 0;

                foreach (var t in Payment)
                {
                    fee += t.Payed;
                }
                var pr=_context.PatientRegisteration.Where(p=>p.PatientRegisterationId==item.PatientRegisterationId).First();
                var patient = _context.Patient.Where(p => p.PatientId == pr.PatientId).First();
                PatientRegistrationViewModel prvm = new PatientRegistrationViewModel
                {
                    patientCheckDate = item.CheckDate,
                    CheckId = item.PatientRegisterationCheckId,
                    doctornote = item.Note,
                    patientName = patient.Name,
                    registrationFee = fee
                };
                PRVM.Add(prvm);
            }

            return new JsonResult(PRVM);
        }
    }
}