using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DentalClinic.Models;

namespace DentalClinic.Controllers
{
    public class DashboardController : Controller
    {
        private readonly DentalClinicContext _context;

        public DashboardController(DentalClinicContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CountPatient()
        {
            var count = _context.Patient.Count();

            return Json(count);
        }

        public ActionResult PatientList()
        {   
            return PartialView("~/Views/StudentViewModel/AddOrEdit.cshtml");
        }
    }
}