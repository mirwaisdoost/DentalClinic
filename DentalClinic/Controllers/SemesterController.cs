using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalClinic.Models;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controlls
{
    public class SemesterController : Controller
    {
        private readonly DentalClinicContext _context;

        public SemesterController(DentalClinicContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Semester> lst = new List<Semester>();
            Semester semester;
            var smstr = _context.Semester;
            foreach(Semester s in smstr)
            {
                semester = new Semester();
                semester.SemesterId = s.SemesterId;
                semester.Name = s.Name;
                lst.Add(semester);
            }
            return View(lst);
        }

        public ActionResult NewSemester(int id)
        {
            AddOrEdit(id);
            return PartialView("~/Views/Semester/AddOrEdit.cshtml");
        }

        public IActionResult AddOrEdit(int id= 0)
        {
            var semester = _context.Semester.Where(p => p.SemesterId == id);

            if (id == 0)
            {
                return View(new Semester());
            }
            else
            {
                Semester smtr = new Semester
                {
                    SemesterId = semester.First().SemesterId,
                    Name = semester.First().Name
                };

                return View(smtr);
            }
        }

        [HttpPost]
        public IActionResult AddOrEdit(int id, string name)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    Semester semester = new Semester
                    {
                        Name = name
                    };
                    _context.Semester.Add(semester);
                    _context.SaveChanges();
                }
                else
                {
                    var s = _context.Semester.Find(id);
                    s.Name = name;

                    _context.Semester.Update(s);
                    _context.SaveChanges();
                }
            }

            return Json("Saved!");
        }

        public async Task<IActionResult> Delete(int id)
        {
            _context.Semester.Remove(_context.Semester.Find(id));

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}