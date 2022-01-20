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
    public class DrugTypesController : Controller
    {
        private readonly DentalClinicContext _context;

        public DrugTypesController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.DrugType.ToListAsync());
        }

        public ActionResult NewDrugType(int id)
        {
            AddOrEdit(id);
            return PartialView("~/Views/DrugTypes/AddOrEdit.cshtml");
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new DrugType());
            else
                return View(_context.DrugType.Find(id));
        }

        [HttpPost]
        public IActionResult AddOrEdit(int id, string name)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    DrugType dt = new DrugType
                    {
                        Name = name
                    };
                    _context.DrugType.Add(dt);
                    _context.SaveChanges();
                }
                else
                {
                    var dt = _context.DrugType.Find(id);
                    dt.Name = name;

                    _context.DrugType.Update(dt);
                    _context.SaveChanges();
                }
            
            }
            return Json("Saved!");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var drugType = await _context.DrugType.FindAsync(id);
            _context.DrugType.Remove(drugType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
