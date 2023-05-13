namespace Layihe2023;

public class Helper
{
    public  T Method5<T>()
    {
        object result;
        Type type = typeof(T);
        Console.ForegroundColor = ConsoleColor.Green;
        var data = Enum.GetValues(type);
        foreach (var item in data)
        {
            byte number = (byte)item;
            string data1 = $"{number}.{item} ucun emeliyyat.";
            for (byte i = 0; i < data1.Length; i++)
            {
                Console.Write(data1[i]);
                Thread.Sleep(5);
            }
            Console.WriteLine();
        }
          Console.ForegroundColor = ConsoleColor.Yellow;
       l1: Method2("Secim edin:");
        if (!Enum.TryParse(type, Console.ReadLine(), true, out result))
        {
           
            Method1("Yalnis Id secdiz zehmet olmasa menyudan secin !");
            goto l1;
        }
        if (!Enum.IsDefined(type, result))
        {
            Method1("Yalnis Id secdiz zehmet olmasa menyudan secin !");
            goto l1;
        }
        return (T)result;
    }
    public void Method1(string name)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" ".PadLeft(20, ' '));
        for (int i = 0; i < name.Length; i++)
        {
            Console.Write(name[i]);
            Thread.Sleep(5);
        }
        Console.WriteLine();
    }
    public void Method2(string info)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" ".PadLeft(20, ' '));
        for (int i = 0; i < info.Length; i++)
        {
            Console.Write(info[i]);
            Thread.Sleep(10);
        }
    }
    public void Method(string info)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" ".PadLeft(20, ' '));
        for (int i = 0; i < info.Length; i++)
        {
            Console.Write(info[i]);
            Thread.Sleep(5);
        }
        Console.WriteLine();
    }
    public void Method6(string info)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        for (int i = 0; i < info.Length; i++)
        {
            Console.Write(info[i]);
            Thread.Sleep(5);
        }
    }
}
