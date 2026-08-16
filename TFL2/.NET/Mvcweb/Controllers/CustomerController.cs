using Customer.Models;
using Microsoft.AspNetCore.Mvc;
namespace Customer.Controllers;
public class CustomerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Details()
    {
        return View();
    }
}
