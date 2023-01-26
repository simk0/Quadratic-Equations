using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Бацура Вiктор IПЗ20к/2\n");
        Console.WriteLine("Вирiшення квадратного рiвняння");
        Console.Write("a = ");

        var a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        var b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        var c = double.Parse(Console.ReadLine());
        
        
        if (a == 0)
        {
            Console.WriteLine("Error:" +
                "Не коректно введенi даннi 'a' не може бути меьше або дорiвнювати нулю");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
        
        
        double x1, x2;
        var discriminant = Math.Pow(b, 2) - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("Рiвняння не має коренiв");
        }
        else
        {
            if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            Console.WriteLine($"x1 = {x1}; x2 = {x2}");
        }

        Console.WriteLine("Щоб завершити программу натиснiть enter");
        Console.ReadKey(true);
    }
}
