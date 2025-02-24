using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть дію:");
        Console.WriteLine("1 - Перетворення з радіан в градуси");
        Console.WriteLine("2 - Перетворення з градусів в радіани");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Введіть значення в радіанах: ");
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * (180 / Math.PI);
            Console.WriteLine($"{radians} радіан = {degrees} градусів");
        }
        else if (choice == 2)
        {
            Console.Write("Введіть значення в градусах: ");
            double degrees = double.Parse(Console.ReadLine());
            double radians = degrees * (Math.PI / 180);
            Console.WriteLine($"{degrees} градусів = {radians} радіан");
        }
        else
        {
            Console.WriteLine("Невірний вибір.");
        }
    }
}
