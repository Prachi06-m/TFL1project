using Microsoft.AspNetCore.Mvc;
using HospitalMVC.Models;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
namespace HospitalMVC.Controllers;
public class DoctorsController:Controller
{
    public IActionResult Index()
    {
        List<Doctor>doctors=new List<Doctor>
        {
            new Doctor
            {
            Id=1,
            Name="Dr.amit sharma",
            Specialization="Cardiologist",
            Qualification="MBBS",
            Phone=9234989390,
            Email="Amit@123"
            },
            new Doctor
            {  Id=2,
            Name="Dr.neha sharma",
            Specialization="Cardiologist",
            Qualification="MBBS/MD",
            Phone=9234988990,
            Email="neha@123"
                
            },
            new Doctor
            {
                  Id=3,
            Name="Dr.nisha sharma",
            Specialization="BDS",
            Qualification="MBBS",
            Phone=9237889390,
            Email="nisha@123"
            }

        };
        return View(doctors);
    }

    }
    


