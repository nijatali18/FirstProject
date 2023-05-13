using Layihe2023.Models;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace Layihe2023;

public class Program
{
   static  GenericStore<Company> companies = new GenericStore<Company>();
   static  GenericStore<Department> departments = new GenericStore<Department>();
   static GenericStore<Employee> employees = new GenericStore<Employee>();
    static void Main(string[] args)
    {
        //Employee employee = new Employee(123456, "Nicat", "Aliyev");
        //string data = employee.ToString();
        //Console.WriteLine(data);

        Helper M1 = new Helper();
        M1.Method("Salam. Siz Menyu secmelisiz.");
        M1.Method("Menyudaki emeliyyatlara nezer yetrin.");
        byte number = (byte)M1.Method5<Menu>();
        switch (number)
        {
            //case 1:
            case 5:
                  Console.Clear();
               l1: M1.Method1("Siz CreateAdd secimini secdiz !");
                byte data = (byte)M1.Method5<Menyu2>();
                if (data == 1)
                {                   
                    Company company ;
                    M1.Method2("Siz AddCompany elave etmek isdediniz !");
                    Console.WriteLine();
                    M1.Method1("Asagidaki melumati doldurun !");                   
                    M1.Method6("Sirketin adi:");
                    string name=Console.ReadLine();
                    companies.CreateAdd(new Company { Name=name});
                    M1.Method("Melumat ugurla elave edildi.");                    
                    Thread.Sleep(3000);
                    Console.Clear();
                    goto l1;
                }
                else if (data == 2)
                {
                    M1.Method2("Siz AddDepartment elave etmek isdediz !");
                    Console.WriteLine();
                    M1.Method1("Asagidaki melumatlari doldurun !");
                    M1.Method6("Iscinin adi:");
                    string name = Console.ReadLine();
                    int employeelimt = M1.MethodInt("Isci limitini daxil edin:");
                    int companyid=M1.MethodInt("Sirketin Id daxil edin:");
                    departments.CreateAdd(new Department { Name = name, Employeelimit = employeelimt, CompanyId= companyid });
                    M1.Method("Melumat ugurla elave edildi.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto l1;
                }
                else if (data==3)
                {   
                    M1.Method2("Siz  Employee elave etmek isdediz !");
                    Console.WriteLine();
                    M1.Method1("Asagidaki melumatlari doldurun !");
                    k1: M1.Method6("Iscinin adi:");
                    string name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Bu xana bos buraxila bilmez !");
                        goto k1;
                    }
                    k2: M1.Method6("Soyadini:");
                    string surname=Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(surname))
                    {
                        Console.WriteLine("Bu xana bos buraxila bilmez !");
                        goto k2;
                    }
                    int salary = M1.MethodInt("Isci mayisini daxil et:");                    
                    employees.CreateAdd(new Employee { Salary=salary,Name=name, Surname = surname  });
                    M1.Method("Melumat ugurla elave edildi.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto l1; 
                }
                goto l1;
        }
    }

}