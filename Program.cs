using System;

class Program
{
    static void Main()
    {
        // Считываем число с клавиатуры
        Console.Write("Введите число: ");
        string input = Console.ReadLine();
        double x;

        // Проверяем, что пользователь ввёл число
        if (!double.TryParse(input, out x))
        {
            Console.WriteLine("Ошибка: введено не число!");
            return;
        }

      
        double result = (Math.Sin(x) + Math.Cos(x)) / 2;

       
        Console.WriteLine($"Результат: {result}");
        Console.WriteLine("");
        Console.WriteLine(" Выполнил: Локтев Артем 23ИС");
    }
}
