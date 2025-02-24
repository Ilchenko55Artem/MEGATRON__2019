using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double denominator = x * x - 8 * x + 12;
        if (denominator == 0)
        {
            Console.WriteLine("Помилка: знаменник дорівнює нулю, вираз не має змісту.");
        }
        else
        {
            double numerator = x * x - 7 * x + 10;
            double result = numerator / denominator;
            Console.WriteLine($"Значення виразу: {result}");
        }
    }
}