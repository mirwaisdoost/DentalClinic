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
    public class DrugElementsController : Controller
    {
        private readonly DentalClinicContext _context;

        public DrugElementsController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dentalClinicContext = _context.DrugElement.Include(d => d.Company).Include(d => d.DrugType);
            return View(await dentalClinicContext.ToListAsync());
        }

        public ActionResult NewDrugElement(int id)
        {
            AddOrEdit(id);
            return PartialView("~/Views/DrugElements/AddOrEdit.cshtml");
        }
        public IActionResult AddOrEdit(int id = 0)
        {
            ViewBag.CompanyId = new SelectList(_context.Company, "CompanyId", "Name");
            ViewBag.DrugTypeId = new SelectList(_context.DrugType, "DrugTypeId", "Name");
            if (id == 0)
                return View(new DrugElement());
            else
                return View(_context.DrugElement.Find(id));
        }

        [HttpPost]
        public IActionResult AddOrEdit(int id, string name, int DrugType, int company, decimal price)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    DrugElement drugElement = new DrugElement
                    {
                        Name = name,
                        DrugTypeId = DrugType,
                        CompanyId = company,
                        Price = price
                    };
                    _context.DrugElement.Add(drugElement);
                    _context.SaveChanges();
                }
                else
                {
                    var de = _context.DrugElement.Find(id);
                    de.Name = name;
                    de.DrugTypeId = DrugType;
                    de.CompanyId = company;
                    de.Price = price;
                    _context.DrugElement.Update(de);
                    _context.SaveChanges();
                }
            }
            return Json("Saved!");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var drugElement = await _context.DrugElement.FindAsync(id);
            _context.DrugElement.Remove(drugElement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
