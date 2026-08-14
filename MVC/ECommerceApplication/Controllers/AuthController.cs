namespace ECommerceApplication.Controllers;
using ECommerceApplication.Models;
using Microsoft.AspNetCore.Mvc;

public class AuthController:Controller
{
   public IActionResult Login()
    {
        Credential credential=new Credential();
        credential.UserName="";
        credential.Password="";
        return View (credential);

    } 
    public IActionResult Login(Credential credential)
    {
        if (credential.UserName=="Admin"&&credential.Password=="TFl")
        {
            return RedirectToAction("Welcome","Home");
        }
        else
        return View();
    }
    public IActionResult Register()
    {
        Customer customer=new Customer();
        customer.Id=2;
        customer.Name="";
        customer.Email="";
        customer.Phone="";
        return View(customer);

     }
     public IActionResult Register(Customer customer)
    {
        return View();
    }
    public IActionResult ChangePassword()
    {
        return View();
    }

}




















    



































    
