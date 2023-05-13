using Layihe2023.Models;
using System.Xml.Linq;

namespace Layihe2023;

public class Program
{
   static  GenericStore<Company> companies = new GenericStore<Company>();
    GenericStore<Department> departments = new GenericStore<Department>();
    GenericStore<Employee> employees = new GenericStore<Employee>();
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
                M1.Method1("Siz elave etmek menyusunu secdiniz !");
                byte data = (byte)M1.Method5<Menyu2>();
                if (data == 1)
                {
                    Company company ;
                    M1.Method2("Siz sirket elave etmek isdediz !");
                    M1.Method1("Asagidaki melumatlari doldurun !");
                    M1.Method6("Sirketin adi:");
                    string name=Console.ReadLine();
                    companies.CreateAdd(new Company { Name=name});
                }
                else if (data == 2)
                {
                    M1.Method2("Siz sirket elave etmek isdediz !");
                    M1.Method1("Asagidaki melumatlari doldurun !");
                    M1.Method6("Sirketin adi:");
                    string name = Console.ReadLine();
                    companies.CreateAdd(new Company { Name = name });
                }

                break;
        }
    }

}