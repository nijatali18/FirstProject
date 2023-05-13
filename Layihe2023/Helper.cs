namespace Layihe2023;

public class Helper
{
    public static T Method5<T>()
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
    l1:  
        if (!Enum.TryParse(type, Console.ReadLine(), true, out result))
        {
            
            goto l1;
        }
        if (!Enum.IsDefined(type, result))
        {
           
            goto l1;
        }
        
        Thread.Sleep(2000);
       
        Thread.Sleep(2000);
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        return (T)result;
    }
    public void Method2(string info)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(" ".PadLeft(20, ' '));
        for (int i = 0; i < info.Length; i++)
        {
            Console.Write(info[i]);
            Thread.Sleep(5);
        }
    }
    public void Method1(string info)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" ".PadLeft(20, ' '));
        for (int i = 0; i < info.Length; i++)
        {
            Console.Write(info[i]);
            Thread.Sleep(5);
        }
        Console.WriteLine();
    }
    public void Method4(string info)
    {
        var color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" ".PadLeft(20, ' '));
        for (int i = 0; i < info.Length; i++)
        {
            Console.Write(info[i]);
            Thread.Sleep(5);
        }
        Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine();
    }
}
