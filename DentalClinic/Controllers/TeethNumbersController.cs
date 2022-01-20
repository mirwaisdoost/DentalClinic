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
    public class TeethNumbersController : Controller
    {
        private readonly DentalClinicContext _context;

        public TeethNumbersController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TeethNumber.ToListAsync());
        }

        public ActionResult NewTeethNumber(int id)
        {
            AddOrEdit(id);
            return PartialView("~/Views/TeethNumbers/AddOrEdit.cshtml");
        }

        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new TeethNumber());
            else
                return View(_context.TeethNumber.Find(id));
        }

        [HttpPost]
        public IActionResult AddOrEdit(int id,int Number,string LeftOrRight,string TopOrButtom,string AduOrChd)
        {
            if (ModelState.IsValid)
            {
                int TeethId = 0;

                if (id == 0)
                {
                    if (_context.TeethNumber.Count() == 0)
                        TeethId = 1;
                    else
                        TeethId = _context.TeethNumber.Max(p => p.TeethNumberId) + 1;

                    TeethNumber teethNumber = new TeethNumber
                    {
                        TeethNumberId=TeethId,
                        Number = Number,
                        LeftOrRight = LeftOrRight,
                        TopOrButtom = TopOrButtom,
                        AduOrChd = AduOrChd
                    };
                    _context.TeethNumber.Add(teethNumber);
                }
                else
                {
                    var tn = _context.TeethNumber.Find(id);
                    tn.Number = Number;
                    tn.LeftOrRight = LeftOrRight;
                    tn.TopOrButtom = TopOrButtom;
                    tn.AduOrChd = AduOrChd;

                    _context.TeethNumber.Update(tn);
                }
                _context.SaveChanges();
            }
            return Json("");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var teethNumber = await _context.TeethNumber.FindAsync(id);
            _context.TeethNumber.Remove(teethNumber);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
