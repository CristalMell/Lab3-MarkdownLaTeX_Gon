// # Задание: Комментированная программа на C#
// Это консольное приложение демонстрирует сложение двух чисел
// с выводом результата в форматированном виде.

// ## Требования к программе:
// 1. Имя файла: `FormatDemo.cs`
// 2. Логика:
//    - Запрашивает у пользователя два числа
//    - Выполняет их сложение
//    - Выводит результаты в форматированном виде

using System;

class Program
{
    static void Main()
    {
        // --- Ввод данных ---
        Console.WriteLine("Введите первое число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Введите второе число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        
        // --- Вычисление суммы ---
        double sum = number1 + number2;
        
        // --- Вывод результата ---
        Console.WriteLine($"Результаты операций: {sum}");
    }
}