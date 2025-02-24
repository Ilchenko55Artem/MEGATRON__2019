using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть коефіцієнт a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть коефіцієнт b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть коефіцієнт c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("Помилка: a не може бути 0.");
            return;
        }

        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("Помилка: дискримінант від’ємний, рівняння не має дійсних коренів.");
        }
        else
        {
            double sqrtD = Math.Sqrt(discriminant);
            double x1 = (-b + sqrtD) / (2 * a);
            double x2 = (-b - sqrtD) / (2 * a);

            Console.WriteLine($"Корені рівняння: x1 = {x1}, x2 = {x2}");
        }
    }
}
