using System;
class Program
{
    static void Main()
    {
        int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };
        Console.WriteLine("Масив:");
        PrintArray(array);
        Console.Write("Введіть два індекси (i1, i2) для суми елементів 3-го стовпця: ");
        int i1 = int.Parse(Console.ReadLine()), i2 = int.Parse(Console.ReadLine());
        if (i1 < array.GetLength(0) && i2 < array.GetLength(0))
            Console.WriteLine($"Сума: {array[i1, 2] + array[i2, 2]}");
        else Console.WriteLine("Невірні індекси!");

        Console.Write("Введіть два індекси (j1, j2) для добутку елементів 2-го рядка: ");
        int j1 = int.Parse(Console.ReadLine()), j2 = int.Parse(Console.ReadLine());
        if (j1 < array.GetLength(1) && j2 < array.GetLength(1))
            Console.WriteLine($"Добуток: {array[1, j1] * array[1, j2]}");
        else Console.WriteLine("Невірні індекси!");
    }
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j] + "\t");
            Console.WriteLine();
        }
    }
}
