namespace SingleArray;
public class Product
{
    public int ID{get;set;}
    public string? Name {get;set;}
    public int Price{get;set;}

    public Product(int ID, string Name, int Price)
    {
        this.ID=ID;
        this.Name=Name;
        this.Price=Price;
    }
    
        Product [] products = new Product[3];
        public Product(){
        products[0]=new Product(1,"Fan",2000);
        products[1]=new Product(2,"refrigerator",15000);
        products[2]=new Product(3,"mixer",2000);
     
        }
           public void Display()
    {
        foreach(Product product1 in products){
        Console.WriteLine(product1.ID);
        Console.WriteLine(product1.Name);
        Console.WriteLine(product1.Price);
        }
    }
}