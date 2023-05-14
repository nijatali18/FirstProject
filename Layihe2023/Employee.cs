using Layihe2023.Models;

namespace Layihe2023;
public class Employee:IEquatable<Employee>, IdIntarface
{
    public int EmployeeId { get; }
    public int Salary { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int DepartmentId { get; }

    public int Id => throw new NotImplementedException();

   

    public override string ToString()
    {
        return $"EmployeeId:{EmployeeId}\nEmployeeName:{Name}\nEmployeeSurname:{Surname}";
    }

    public bool Equals(Employee? other)
    {
        throw new NotImplementedException();
    }

    static int count = 0;
    public Employee()
    {
        count++;
        this.EmployeeId = count;
    }
}
