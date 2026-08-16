using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HospitalMVC.Models;

namespace HospitalMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    
}
