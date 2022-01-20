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
    public class SessionsController : Controller
    {
        private readonly DentalClinicContext _context;

        public SessionsController(DentalClinicContext context)
        {
            _context = context;
        }

        // GET: Sessions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Session.ToListAsync());
        }

        public ActionResult NewSession(int id)
        {
            AddOrEdit(id);
            return PartialView("~/Views/Sessions/AddOrEdit.cshtml");
        }

        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Session());
            else
                return View(_context.Session.Find(id));
        }

        [HttpPost]
        public IActionResult AddOrEdit(int id,string name, byte status)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    Session session = new Session
                    {
                        Name = name,
                        Status = status
                    };
                    _context.Session.Add(session);
                    _context.SaveChanges();
                }
                else
                {
                    var s = _context.Session.Find(id);
                    s.Name = name;
                    s.Status = status;

                    _context.Session.Update(s);
                    _context.SaveChanges();
                }
            }
            return Json("Saved!");
        }
        
       
        public async Task<IActionResult> Delete(int? id)
        {
            var session = await _context.Session.FindAsync(id);

            _context.Session.Remove(session);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
