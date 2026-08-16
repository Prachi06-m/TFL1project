

namespace Array1;
public class Product
{
    public int Id{get;set;}
   public string ?Name{get;set;}
    public int Price{get;set;}

public  Product(int Id,string Name,int Price)
    {
        this.Id=Id;
        this.Name=Name;
        this.Price=Price;
    }

  Product[]products=new Product[3];
  
  public  Product()
  {
    products[0]=new Product(1,"fan",2000);
    products[1]=new Product(2,"referigertor",3000);
    products[2]=new Product(3,"cooker",5000);
      
  }
  


          public void Display()
    {
        foreach(Product product1 in products){
        Console.WriteLine(product1.Id);
        Console.WriteLine(product1.Name);
        Console.WriteLine(product1.Price);
        }
    }   
}