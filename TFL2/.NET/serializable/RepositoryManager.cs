public class RepositoryManager
{
    public void Serialize(List<Employee> employees, string fileName)
    {
        var options = new JsonSerializerOptions { IncludeFields = true };
        var employeesJson = JsonSerializer.Serialize(employees, options);
        File.WriteAllText(fileName, employeesJson);
    }

    public List<Employee> DeSerialize(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
        foreach (Employee emp in employees)
        {
            Console.WriteLine($"{emp.Id} : {emp.Name}");
        }
        return employees;
    }
}
     