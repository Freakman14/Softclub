using Domain.Models;
namespace Infrastructure.Services;

public class EmployeeService
{
    List<Employee> empl = new List<Employee>();

    public List<Employee> GetEmployees()
    {
        return empl;
    }
    public void AddEmployees(Employee _empl)
    {
        empl.Add(_empl);
    }

    
}
