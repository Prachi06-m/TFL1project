using System.Security.Cryptography.X509Certificates;

namespace HospitalMVC.Models;
public class Appointment
{
    public int Id{get;set;}
    public string Patientname{get;set;}
    public string Doctorname{get;set;}
    public DateTime AppointmentDate{get;set;}
    public string Disease{get;set;}


}
