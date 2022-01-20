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
    public class HistoryElementsController : Controller
    {
        private readonly DentalClinicContext _context;

        public HistoryElementsController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var HistoryElement = _context.HistoryElement.Include(p => p.ApplyToGenderNavigation);
            return View(await HistoryElement.ToListAsync());
        }

        public ActionResult NewHistoryElement(int id)
        {
            AddOrEdit(id);
            Gender();
            return PartialView("~/Views/HistoryElements/AddOrEdit.cshtml");
        }

        private void Gender()
        {
            List<Gender> gender = new List<Gender>();
            gender = (from item in _context.Gender select item).ToList();
            ViewBag.gender = gender;
        }

        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new HistoryElement());
            else
                return View(_context.HistoryElement.Find(id));
        }

        [HttpPost]
        public IActionResult AddOrEdit(int id,string name,int gender)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    HistoryElement historyElement = new HistoryElement
                    {
                        Name = name,
                        ApplyToGender = gender
                    };
                    _context.HistoryElement.Add(historyElement);
                    _context.SaveChanges();
                }
                else
                {
                    var he = _context.HistoryElement.Find(id);
                    he.Name = name;
                    he.ApplyToGender = gender;

                    _context.HistoryElement.Update(he);
                    _context.SaveChanges();
                }
            }
            return Json("Saved!");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var historyElement = await _context.HistoryElement.FindAsync(id);
            _context.HistoryElement.Remove(historyElement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
