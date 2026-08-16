using Microsoft.AspNetCore.Mvc;
using HospitalMVC.Models;

namespace HospitalMVC.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            ViewBag.Message = "Appointment Booked Successfully!";
            return View();
        }
    }
}