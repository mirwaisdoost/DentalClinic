using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DentalClinic.Models;
using Microsoft.AspNetCore.Mvc;

namespace DentalClinic.Controlls
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}