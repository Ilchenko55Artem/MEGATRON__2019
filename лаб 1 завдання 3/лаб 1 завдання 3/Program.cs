using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть чотиризначне число N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N < 1000 || N > 9999)
        {
            Console.WriteLine("Помилка: число має бути чотиризначним.");
            return;
        }

        int d1 = N / 1000;
        int d2 = (N / 100) % 10;
        int d3 = (N / 10) % 10;
        int d4 = N % 10;

        bool allDifferent = (d1 != d2) && (d1 != d3) && (d1 != d4) &&
                            (d2 != d3) && (d2 != d4) &&
                            (d3 != d4);

        Console.WriteLine(allDifferent);
    }
}
