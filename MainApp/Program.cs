using Domain.Models;
using Infrastructure.Services;

var e1 = new Employee();
e1.Firstname = "Daler";
e1.Lastname = "Toshev";
e1.BirthDate = 23;
e1.Salary = 23;
e1.Department = "Deep";

var es1 = new EmployeeService();
es1.AddEmployees(e1);

foreach (var item in es1.GetEmployees())
{
    System.Console.WriteLine($"Name: {item.Firstname}");
    System.Console.WriteLine($"Surname: {item.Lastname}");
    System.Console.WriteLine($"Birtday: {item.BirthDate}");
}