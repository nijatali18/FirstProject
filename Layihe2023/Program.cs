using Layihe2023.Models;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace Layihe2023;

public class Program
{
    static GenericStore<Company> companies = new GenericStore<Company>();
    static GenericStore<Department> departments = new GenericStore<Department>();
    static GenericStore<Employee> employees = new GenericStore<Employee>();
    Department department;
    static void Main(string[] args)
    {
        //Employee employee = new Employee(123456, "Nicat", "Aliyev");
        //string data = employee.ToString();
        //Console.WriteLine(data);
        departments.CreateAdd(new Department { Name = "samir", Employeelimit = 2, CompanyId = 1 });
        companies.CreateAdd(new Company { Name = "samir" });
        Helper M1 = new Helper();
    l6: M1.Method("Salam. Siz Menyu secmelisiz.");
        M1.Method("Menyudaki emeliyyatlara nezer yetrin.");
        byte number = (byte)M1.Method5<Menu>();
        if (number == 1)
        {
            M1.Method1("Siz CreateAdd secimini secdiz !");
            Thread.Sleep(3000);

        l1:
            Console.Clear();
            M1.Method("Menyudan secim ede bilersiz !");
            byte data = (byte)M1.Method5<Menyu2>();
            switch (data)
            {
                case 1:
                    string name;
                    Company company;
                    M1.Method2("Siz AddCompany elave etmek isdediniz !");
                    Console.WriteLine();
                    M1.Method1("Asagidaki melumati doldurun !");
                    M1.Method6("Sirketin adi:");
                    name = Console.ReadLine();
                    companies.CreateAdd(new Company { Name = name });
                    M1.Method("Melumat ugurla elave edildi.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    goto l1;

                case 2:
                    if (companies.Count == 0)
                    {
                        M1.Method1("Sovbe elave etmek ucun ilk once sirket elave et.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto case 1;
                    }
                    M1.Method2("Siz AddDepartment elave etmek isdediz !");
                    Console.WriteLine();
                    M1.Method1("Asagidaki melumatlari doldurun !");
                    M1.Method6("Iscinin adi:");
                    string name1 = Console.ReadLine();
                    int employeelimt = M1.MethodInt("Isci limitini daxil edin:");
                    int companyid = M1.MethodInt("Sirketin Id daxil edin:");
                    departments.CreateAdd(new Department { Name = name1, Employeelimit = employeelimt, CompanyId = companyid });
                    M1.Method("Melumat ugurla elave edildi.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto l1;
                case 3:
                    if (departments.Count == 0)
                    {
                        M1.Method1("Isci elave etmek ucun ilk once Sovbe elave et.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto case 2;
                    }
                    string name2;
                    M1.Method2("Siz  Employee elave etmek isdediz !");
                    Console.WriteLine();
                    M1.Method1("Asagidaki melumatlari doldurun !");
                k1: M1.Method6("Iscinin adi:");
                    name2 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name2))
                    {
                        Console.WriteLine("Bu xana bos buraxila bilmez !");
                        goto k1;
                    }
                k2: M1.Method6("Soyadini:");
                    string surname = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(surname))
                    {
                        Console.WriteLine("Bu xana bos buraxila bilmez !");
                        goto k2;
                    }
                    int salary = M1.MethodInt("Isci mayisini daxil et:");
                    Console.WriteLine(" Departamentin Id asagidakilardan daxil ede bilersiz !");
                    GetAllDeptametId();
                j1: int departamentid = M1.MethodInt("Departamentin Id daxil et:");
                    if (departments.Equals(departamentid))
                    {
                        Console.WriteLine("Departamet Id-ni yuxaridan secin !");
                        goto j1;

                    }
                    employees.CreateAdd(new Employee { Salary = salary, Name = name2, Surname = surname });
                    M1.Method("Melumat ugurla elave edildi.");
                    Thread.Sleep(2000);
                    goto l1;

                case 4:
                    M1.Method1("Esas menyuya donus olunur !");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto l6;

            }

        }
        static void GetAllDeptametId()
        {
            foreach (var item in departments)
            {
                Console.WriteLine($"Book Id:{item.DepartmentId}");
               
            }
        }


        //employee { Salary = salary,Name = name, Surname = surname  });
        //M1.Method("Melumat ugurla elave //switch (number)
        //{
        //    Console.Clear();
        //l1: M1.Method1("Siz CreateAdd secimini secdiz !");
        //    byte data = (byte)M1.Method5<Menyu2>();
        //    case 1:

        //        if (data == 1)
        //    {
        //        Company company;
        //        M1.Method2("Siz AddCompany elave etmek isdediniz !");
        //        Console.WriteLine();
        //        M1.Method1("Asagidaki melumati doldurun !");
        //        M1.Method6("Sirketin adi:");
        //        string name = Console.ReadLine();
        //        companies.CreateAdd(new Company { Name = name });
        //        M1.Method("Melumat ugurla elave edildi.");
        //        Thread.Sleep(3000);
        //        Console.Clear();
        //        goto l1;
        //    }
        //    else if (data == 2)
        //    {
        //        M1.Method2("Siz AddDepartment elave etmek isdediz !");
        //        Console.WriteLine();
        //        M1.Method1("Asagidaki melumatlari doldurun !");
        //        M1.Method6("Iscinin adi:");
        //        string name = Console.ReadLine();
        //        int employeelimt = M1.MethodInt("Isci limitini daxil edin:");
        //        int companyid = M1.MethodInt("Sirketin Id daxil edin:");
        //        departments.CreateAdd(new Department { Name = name, Employeelimit = employeelimt, CompanyId = companyid });
        //        M1.Method("Melumat ugurla elave edildi.");
        //        Thread.Sleep(2000);
        //        Console.Clear();
        //        goto l1;
        //    }
        //    else if (data == 3)
        //    {
        //        M1.Method2("Siz  Employee elave etmek isdediz !");
        //        Console.WriteLine();
        //        M1.Method1("Asagidaki melumatlari doldurun !");
        //    k1: M1.Method6("Iscinin adi:");
        //        string name = Console.ReadLine();
        //        if (string.IsNullOrWhiteSpace(name))
        //        {
        //            Console.WriteLine("Bu xana bos buraxila bilmez !");
        //            goto k1;
        //        }
        //    k2: M1.Method6("Soyadini:");
        //        string surname = Console.ReadLine();
        //        if (string.IsNullOrWhiteSpace(surname))
        //        {
        //            Console.WriteLine("Bu xana bos buraxila bilmez !");
        //            goto k2;
        //        }
        //        int salary = M1.MethodInt("Isci mayisini daxil et:");
        //        employees.CreateAdd(new Emedildi.");

        //        Thread.Sleep(2000);
        //        Console.Clear();
        //        goto l1;
        //    }
        //    else if (data == 4)
        //    {
        //        goto l6;
        //    }
        //    default: break;

        //}
    }
}

