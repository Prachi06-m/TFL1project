using Microsoft.AspNetCore.Mvc;
using HospitalMVC.Models;

namespace HospitalMVC.Controllers
{
    public class PatientsController : Controller
    {
        public IActionResult Index()
        {
            List<Patient> patients = new List<Patient>()
            {
                new Patient
                {
                    Id = 1,
                    Name = "Rohan",
                    Age = 25,
                    Gender = "Male",
                    Phone = "9999999999",
                    Address = "Pune"
                },

                new Patient
                {
                    Id = 2,
                    Name = "Priya",
                    Age = 30,
                    Gender = "Female",
                    Phone = "8888888888",
                    Address = "Mumbai"
                }
            };

            return View(patients);
        }
    }
}