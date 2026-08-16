
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using Hrsynclab;
class Program
{
    static async Task Main()
    {
        Console.WriteLine("HR System Started...\n");

        HROperationService service = new HROperationService();

        // Async call to fetch employees
        var employees = await service.GetEmployeesAsync();

        Console.WriteLine("Employees Loaded:");
        employees.ForEach(e => Console.WriteLine(e));

        Console.WriteLine("\nCalculating bonus asynchronously...");
        double bonus = await service.CalculateBonusAsync(employees[0]);
        Console.WriteLine($"Bonus for {employees[0].Name}: {bonus}");

        await service.SaveEmployeeAsync(employees[0]);

        Console.WriteLine("\nHR System Completed.");
    }
}









using Hrservices;
public class Program
{
    Console.WriteLine("hr System started/n");
    var employees=await ser
}














