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
    public class FeeElementsController : Controller
    {
        private readonly DentalClinicContext _context;

        public FeeElementsController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dentalClinicContext = _context.FeeElement.Include(f => f.FeeType);
            return View(await dentalClinicContext.ToListAsync());
        }

        public ActionResult NewFeeElement(int id)
        {
            AddOrEdit(id);
            return PartialView("~/Views/FeeElements/AddOrEdit.cshtml");
        }

        private IActionResult AddOrEdit(int id=0)
        {
            ViewData["FeeTypeId"] = new SelectList(_context.FeeType, "FeeTypeId", "Name");
            if (id == 0)
                return View(new FeeElement());
            else
                return View(_context.FeeElement.Find(id));
        }

      
        [HttpPost]
        public IActionResult AddOrEdit(int id,int FeeType, string Name, decimal Fee)
        {
            if (ModelState.IsValid)
            {
                int Fid = 1;

                if (id == 0)
                {
                    if (_context.FeeElement.Count() == 0)
                    {
                        Fid = 1;
                    }
                    else
                    {
                        Fid = _context.FeeElement.Max(p => p.FeeElementId) + 1;
                    }

                    FeeElement feeElement = new FeeElement
                    {
                        FeeElementId=Fid,
                        Name = Name,
                        FeeTypeId = FeeType,
                        Fee = Fee
                    };
                    _context.FeeElement.Add(feeElement);
                    _context.SaveChanges();
                }
                else
                {
                    var fe = _context.FeeElement.Find(id);
                    fe.Name = Name;
                    fe.FeeTypeId = FeeType;
                    fe.Fee = Fee;

                    _context.FeeElement.Update(fe);
                    _context.SaveChanges();
                }
            }
            return Json("Saved!");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var feeElement = await _context.FeeElement.FindAsync(id);
            _context.FeeElement.Remove(feeElement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
