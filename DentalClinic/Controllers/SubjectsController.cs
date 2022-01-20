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
    public class SubjectsController : Controller
    {
        private readonly DentalClinicContext _context;

        public SubjectsController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Subject.ToListAsync());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Subject());
            else
                return View(_context.Subject.Find(id));
        }

        public ActionResult NewSubject(int id)
        {
            AddOrEdit(id);
            return PartialView("~/Views/Subjects/AddOrEdit.cshtml");
        }

        [HttpPost]
        public IActionResult AddOrEdit(int id, string name)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    Subject subject = new Subject
                    {
                        Name = name
                    };
                    _context.Subject.Add(subject);
                    _context.SaveChanges();
                }
                else
                {
                    var sub = _context.Subject.Find(id);
                    sub.Name = name;

                    _context.Subject.Update(sub);
                    _context.SaveChanges();
                }
            }
            return Json("Saved!");
        }

       
       
        public async Task<IActionResult> Delete(int? id)
        {
            var subject = await _context.Subject.FindAsync(id);
           
            _context.Subject.Remove(subject);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
