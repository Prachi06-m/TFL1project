
namespace collection;
public class Player{
    public int PlayerId{get;set;}
    public string Name{get;set;}
    public int JercyName{get;set;}
    public string Position{get;set;}
    public int Age{get;set;}
    public decimal Salary{get;set;}

    public Player(int playerId,string name,int jercyName,string position,int age,decimal salary){
        PlayerId=playerId;
        Name=name;
        JercyName=jercyName;
        Position=position;
        Age=age;
        Salary=salary;
    } 
}