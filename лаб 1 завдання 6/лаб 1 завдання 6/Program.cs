using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість елементів масиву: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Введіть елементи масиву:");

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] compressedArray = Array.FindAll(array, element => element != 0);

        Console.WriteLine("Масив після стиснення:");

        foreach (int item in compressedArray)
        {
            Console.WriteLine(item);
        }
    }
}
