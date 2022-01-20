using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DentalClinic.Models;
using DentalClinic.ViewModels;

namespace DentalClinic.Controlls
{
    public class PatientsController : Controller
    {
        private readonly DentalClinicContext _context;

        public PatientsController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dentalClinicContext = _context.Patient.Include(d => d.Gender);
            return View(await dentalClinicContext.ToListAsync());
        }

        public IActionResult PatientList()
        {
            var dentalClinicContext = _context.Patient.ToList();
            List<PatientViewModel> patient = new List<PatientViewModel>();
            foreach(var t in dentalClinicContext)
            {
                PatientViewModel p = new PatientViewModel
                {
                    PatientId = t.PatientId,
                    Name = t.Name,
                    LastName=t.LastName,
                    GenderName=t.Name,
                    DataOfBrith=t.DataOfBrith,
                    Job=t.Job,
                    Phone=t.Phone,
                    Address=t.Address
                };
                patient.Add(p);
            }
            return new JsonResult(patient);
        }

        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Patient());
            else
                return View(_context.Patient.Find(id));
        }

        public ActionResult NewPatient(int id)
        {
            AddOrEdit(id);
            return PartialView("~/Views/Patients/PatientModal.cshtml");
        }

        [HttpPost]
        public IActionResult AddOrEdit(int id,string name, string lastName, int genderID,DateTime dateOfBirth,string job,string phone,string address)
        {
            if (ModelState.IsValid)
            {
                int Pid = 0;
                if (id == 0)
                {
                    if (_context.Patient.Count() == 0)
                    {
                        Pid = 1;
                    }
                    else
                    {
                        Pid = _context.Patient.Max(p => p.PatientId) + 1;
                    }
                    Patient patient = new Patient
                    {
                        PatientId = Pid,
                        Name = name,
                        LastName = lastName,
                        Job = job,
                        Phone = phone,
                        Address = address,
                        GenderId = genderID,
                        DataOfBrith = dateOfBirth
                    };
                    _context.Patient.Add(patient);
                    _context.SaveChanges();
                }
                else
                {
                    var p = _context.Patient.Find(id);
                    p.PatientId = id;
                    p.Name = name;
                    p.LastName = lastName;
                    p.Job = job;
                    p.Phone = phone;
                    p.Address = address;
                    p.GenderId = genderID;
                    p.DataOfBrith = dateOfBirth;

                    _context.Patient.Update(p);
                    _context.SaveChanges();
                }
            }
            return Json("Saved");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var patient = await _context.Patient.FindAsync(id);
            _context.Patient.Remove(patient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
