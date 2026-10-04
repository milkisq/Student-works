using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в калькулятор");
        Console.WriteLine("Введите первое число:");
        double a = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите второе число:");
        double b = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Выберите операцию (+, *):");
        string operation = Console.ReadLine()!;

        double result = operation == "+" ? a + b : a * b;

        Console.WriteLine($"Результат: {result}");
    }
}