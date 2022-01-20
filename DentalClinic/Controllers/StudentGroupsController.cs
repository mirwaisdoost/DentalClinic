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
    public class StudentGroupsController : Controller
    {
        private readonly DentalClinicContext _context;

        public StudentGroupsController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentGroup.ToListAsync());
        }

        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new StudentGroup());
            else
                return View(_context.StudentGroup.Find(id));
        }

        public ActionResult NewStudentGroup(int id)
        {
            AddOrEdit(id);
            return PartialView("~/Views/StudentGroups/AddOrEdit.cshtml");
        }


        [HttpPost]
        public IActionResult AddOrEdit(int id,string name)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    StudentGroup studentGroup = new StudentGroup
                    {
                        Name = name
                    };
                    _context.StudentGroup.Add(studentGroup);
                    _context.SaveChanges();
                }
                else
                {
                    var sg = _context.StudentGroup.Find(id);
                    sg.Name = name;

                    _context.StudentGroup.Update(sg);
                    _context.SaveChanges();
                }
            }
            return Json("");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var studentGroup = await _context.StudentGroup.FindAsync(id);
            _context.StudentGroup.Remove(studentGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
