namespace ECommerceApplication.Controllers;
using ECommerceApplication.Models;
using Microsoft.AspNetCore.Mvc;

public class ProductController:Controller
{
    private static List<Product>products=new List<Product>()
    {new Product{Id=101,Name="Prachi",Price=2000},
    new Product{Id=102,Name="Payal",Price=3000},
    new Product{Id=103,Name="Purva",Price=4000}
        
    };
    //user Browser thorough Request 
    //Display all Products
    public IActionResult List()
    {
    return View(products);
    }
    //Httpget Method
    //User Request to show details and when ID=id,
    //id matched product is display 
    //when product is null return not Found is Display 404 Error

    public IActionResult Details(int id)
    {
        Product product=products.FirstOrDefault(p=>p.Id==id);
        if(product==null)
        {
            return NotFound();
        }
        return View (product);
    }

    
    
    //http get method 
    //display form to user when user Insert Request send on Browser
    public IActionResult  Insert()
    {
        return View();
    }
    //HttpPost Method
    //when user submit the form this method work user saw new list
    public IActionResult Insert(Product product)

    {
        products.Add(product);
        return RedirectToAction("List");
    }
    //get
    public IActionResult Update(int id)
    {
        Product product=products.FirstOrDefault(p=>p.Id==id);
        if(product==null)
        {
            return NotFound();
        }
        return View(product);

    }
    //Post
    public IActionResult Update(Product product)
    {
        Product existingProduct =products.FirstOrDefault(p=>p.Id==product.Id);
        
    if (existingProduct !=null)
    {
        existingProduct.Name=product.Name;
        existingProduct.Price=product.Price;
    }
    return RedirectToAction ("List");
    }
    //get method
    public IActionResult Reomve(int id)
    {
        Product product=products.FirstOrDefault(p=>p.Id==id);
        if(product==null)
        {
            return NotFound();
        }
        return View (product);
    }
    public IActionResult Remove(Product product)
{
//Product existingProduct=products.FirstOrDefault(p=>p.Id

        Product existingProduct=products.FirstOrDefault(p=>p.Id==product.Id);
    if (existingProduct !=null)
        {
            products.Remove(existingProduct);
        }
        return RedirectToAction("List");
  }
}



