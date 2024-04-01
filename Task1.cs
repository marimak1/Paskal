using System;
class Task1
{
    public Task1()
    {
            int sum = 0;
            int number;

            // Запрашиваем ввод числа у пользователя
            Console.WriteLine("Введите число (0 для завершения): ");
            number = int.Parse(Console.ReadLine());

            // Продолжаем запрашивать числа, пока пользователь не введет 0
            while (number != 0)
            {
                // Добавляем введенное число к сумме
                sum += number;

                // Запрашиваем следующее число
                Console.WriteLine("Введите число (0 для завершения): ");
                number = int.Parse(Console.ReadLine());
            }

            // Выводим сумму введенных чисел
            Console.WriteLine("Сумма введенных чисел: " + sum);
    }
    }
