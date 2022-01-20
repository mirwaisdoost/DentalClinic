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
    public class DoctorsController : Controller
    {
        private readonly DentalClinicContext _context;

        public DoctorsController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Doctor.ToListAsync());
        }
            
        public ActionResult NewDoctor(int id)
        {
            AddOrEdit(id);
            return PartialView("~/Views/Doctors/AddOrEdit.cshtml");
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Doctor());
            else
                return View(_context.Doctor.Find(id));

        }

        [HttpPost]
        public IActionResult AddOrEdit(int id,string Name, string FatherName, string LastName, string Job, string JobLocation, string Phone, string Email)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    Doctor doctor = new Doctor
                    {
                        Name = Name,
                        FatherName = FatherName,
                        LastName = LastName,
                        Jop = Job,
                        JobLocation = JobLocation,
                        Phone = Phone,
                        Email = Email
                    };
                    _context.Doctor.Add(doctor);
                    _context.SaveChanges();
                }
                else
                {
                    var doctor = _context.Doctor.Find(id);
                    doctor.Name = Name;
                    doctor.FatherName = FatherName;
                    doctor.LastName = LastName;
                    doctor.Jop = Job;
                    doctor.JobLocation = JobLocation;
                    doctor.Phone = Phone;
                    doctor.Email = Email;

                    _context.Doctor.Update(doctor);
                    _context.SaveChanges();
                }
            }
            return Json("Saved!");
        }

        public async Task<IActionResult> Delete(int? id)
        {

            var doctor = await _context.Doctor.FindAsync(id);
            _context.Doctor.Remove(doctor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
