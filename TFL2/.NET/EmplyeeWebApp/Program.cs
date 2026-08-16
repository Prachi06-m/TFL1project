using empservices;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/api/employees", () =>{return EmployeeServices.GetAll();});
app.MapPost("/api/employees",()=>{ return EmployeeServices.Insert();});
app.Run();





