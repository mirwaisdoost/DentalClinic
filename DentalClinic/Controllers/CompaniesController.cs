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
    public class CompaniesController : Controller
    {
        private readonly DentalClinicContext _context;

        public CompaniesController(DentalClinicContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Company.ToListAsync());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Company());
            else
                return View(_context.Company.Find(id));
        }

        
        public ActionResult NewCompany(int id)
        {
            AddOrEdit(id);
            return PartialView("~/Views/Companies/AddOrEdit.cshtml");
        }

        [HttpPost]
        public IActionResult AddOrEdit(int id,string name)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    Company company = new Company
                    {
                        Name = name,
                    };
                    _context.Company.Add(company);
                }
                else
                {
                    var company = _context.Company.Find(id);
                    company.Name = name;
                    _context.Company.Update(company);
                }
                _context.SaveChanges();
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var company = _context.Company.Find(id);

            _context.Company.Remove(company);
            _context.SaveChanges();
            return Json("Deleted!");
        }
    }
}
