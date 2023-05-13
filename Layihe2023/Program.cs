namespace Layihe2023;

internal class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee(123456, "Nicat", "Aliyev");

        string data = employee.ToString();

        Console.WriteLine(data);

    }

}