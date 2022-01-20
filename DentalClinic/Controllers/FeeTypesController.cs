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
    public class FeeTypesController : Controller
    {
        private readonly DentalClinicContext _context;

        public FeeTypesController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.FeeType.ToListAsync());
        }

        public ActionResult NewFeeType(int id)
        {
            AddOrEdit(id);
            return PartialView("~/Views/FeeTypes/AddOrEdit.cshtml");
        }

        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new FeeType());
            else
                return View(_context.FeeType.Find(id));
        }

        [HttpPost]
        public IActionResult AddOrEdit(int id,string name)
        {
            if (ModelState.IsValid)
            {
                int Fid = 1;
                if (id == 0)
                {
                    if (_context.FeeType.Count() == 0)
                    {
                        Fid = 1;
                    }
                    else
                    {
                        Fid = _context.FeeType.Max(p => p.FeeTypeId) + 1;
                    }
                    FeeType ft = new FeeType
                    {
                        FeeTypeId= Fid,
                        Name = name
                    };
                    _context.FeeType.Add(ft);
                    _context.SaveChanges();
                }
                else
                {
                    var ft = _context.FeeType.Find(id);
                    ft.Name = name;

                    _context.FeeType.Update(ft);
                    _context.SaveChanges();
                }
            }
            return Json("Saved!");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var feeType = await _context.FeeType.FindAsync(id);
            _context.FeeType.Remove(feeType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
