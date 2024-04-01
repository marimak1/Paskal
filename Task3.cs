using System;
class Task3
{
    public Task3()
    {
        // Запрашиваем у пользователя ввод y

        Console.WriteLine("Введите y: ");
        double y = double.Parse(Console.ReadLine());

        // Вычисляем f(x) в зависимости от значения y
        double result = 0;
        if (y < 1)
        {
        result = ((y*y)+(2*y)+3/10);
        }
        else if (y > 2)
        {
        result = (y+2);
        }
        else if ((y >= 1) && (y <= 2))
        {
        result = ((y*y*y)+(2*(y*y))+(3/10*y)+1);
        }

        // Выводим результат
         Console.WriteLine("f(x) = " + result);
    }
}