using System;
class Task2
{
    public Task2()
    {
        Console.Write("Введите строну а: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите строну b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите строну c: ");
        double c = double.Parse(Console.ReadLine());
        if ((a + b > c) && (b + c > a) && (a + c > b))
        {
            double p = (a + b + c) / 2;
            Console.WriteLine("Это треугольник");
            Console.WriteLine("Площадь треугольника: " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
        else
        {
            Console.WriteLine("Это не треугольник");
        }
        Console.ReadKey();
    }
}
