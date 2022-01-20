using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalClinic.Models;
using DentalClinic.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controllers
{
    public class StagerReportController : Controller
    {
        private readonly DentalClinicContext _context;

        public StagerReportController(DentalClinicContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StagerReport(DateTime From, DateTime To, int StagerId)
        {
            var PatientReport = _context.PatientRegisterationCheck.Where(p =>
                                p.CheckDate >= From && p.CheckDate <= To && p.StudentId== StagerId).ToList();

            List<PatientRegistrationViewModel> PRVM = new List<PatientRegistrationViewModel>();
            foreach (var item in PatientReport)
            {
                var Payment = _context.PatientRegisterationPayment.Where(p => p.PatientRegisterationCheckId == item.PatientRegisterationCheckId);
                decimal? fee = 0;

                foreach (var t in Payment)
                {
                    fee += t.Payed;
                }
                var pr = _context.PatientRegisteration.Where(p => p.PatientRegisterationId == item.PatientRegisterationId).First();
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

        public JsonResult AutoCompleteStudentSelect(string term)
        {
            var doctor = (from item in _context.Student.Where(p => p.Name.Contains(term))
                          select new
                          { label = item.Name, id = item.StudentId }).ToList();
            return Json(doctor);
        }

    }
}