
using System.Data;
using ECommerceApplication.Moddels;
using ECommerceApplication.Models;
using Microsoft.AspNetCore.Mvc;
namespace ECommerceApplication.Controllers;
public class CustomerController:Controller
{
public IActionResult Aboutus()
    {
        string content="Doing Ordinary things Extraordinary";
        ViewData["Message"]="Content";
        return View();
    }
public IActionResult Contactus()
{
    Address address=new Address
    {
        Street="601,Pune Satara road",
        City="Pune",
        State="mh",
        Zipcode="41009"

        
    };

    ViewData["Address"]= address;
    return View();
}
 
     public IActionResult Dashboard()
    {
        return View();  
        
    }
}
