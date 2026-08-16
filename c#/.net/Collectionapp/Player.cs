

namespace Collectionapp;
public class Player
{
    
    public int PlayerID{get;set;}
    public string Name{get;set;}
    public int Jerseyno{get;set;}
    public string Position{get;set;}
    public int Age{get;set;}

    public decimal Salary{get;set;}


public Player(int playerID,string name,int jerseyno,string position,int age,decimal salary)
    {
        PlayerID=playerID;
        Name=name;
        Jerseyno=jerseyno;
        Position=position;
        Age=age;
        Salary=salary;
    }
}    








        
    
