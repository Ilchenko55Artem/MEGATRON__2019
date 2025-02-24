using System;

class Program
{
    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Введіть значення n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введіть значення t: ");
        int t = int.Parse(Console.ReadLine());

        Console.WriteLine("Числа, менші за {0}, квадрат суми цифр яких дорівнює {1}:", n, t);

        for (int i = 1; i < n; i++)
        {
            int sum = SumOfDigits(i);
            if (sum * sum == t)
            {
                Console.WriteLine(i);
            }
        }
    }
}

