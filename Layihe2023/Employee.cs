namespace Layihe2023;
public class Employee
{
    public int Id { get; }
    public int Salary { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int DepartmentId { get; set; }

    public override string ToString()
    {
        return $"EmployeeId:{Id}\nEmployeeName:{Name}\nEmployeeSurname:{Surname}";
    }
    static int count = 0;
    public Employee(int salary, string name, string surname)
    {
        count++;
        this.Id = count;
        this.Salary = salary;
        this.Name = name;
        this.Surname = surname;
    }
}
