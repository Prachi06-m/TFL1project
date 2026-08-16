using System.Security.Cryptography.X509Certificates;

namespace HospitalMVC.Models;
public class Doctor
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Specialization{get;set;}
    public string Qualification{get;set;}
    public Decimal Phone{get;set;}
    public string Email{get;set;}

}