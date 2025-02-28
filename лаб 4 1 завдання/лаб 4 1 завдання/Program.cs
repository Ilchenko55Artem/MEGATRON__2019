using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість елементів масиву: ");
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++) array[i] = double.Parse(Console.ReadLine());
        int minAbsIndex = FindMinAbsIndex(array);
        Console.WriteLine($"Номер мінімального за модулем елемента: {minAbsIndex}");
        double sumAfterFirstNegative = SumAbsAfterFirstNegative(array);
        Console.WriteLine($"Сума модулів елементів після першого від’ємного: {sumAfterFirstNegative}");
        Console.Write("Введіть межі інтервалу для видалення (min max): ");
        string[] bounds = Console.ReadLine().Split();
        double minBound = double.Parse(bounds[0]), maxBound = double.Parse(bounds[1]);
        array = CompressArray(array, minBound, maxBound);
        Console.WriteLine("Оновлений масив:");
        Console.WriteLine(string.Join(" ", array));
    }
    static int FindMinAbsIndex(double[] array)
    {
        int index = 0;
        double minAbsValue = Math.Abs(array[0]);
        for (int i = 1; i < array.Length; i++)
            if (Math.Abs(array[i]) < minAbsValue) { minAbsValue = Math.Abs(array[i]); index = i; }
        return index;
    }
    static double SumAbsAfterFirstNegative(double[] array)
    {
        int firstNegIndex = Array.FindIndex(array, x => x < 0);
        if (firstNegIndex == -1 || firstNegIndex == array.Length - 1) return 0;
        return array.Skip(firstNegIndex + 1).Select(Math.Abs).Sum();
    }
    static double[] CompressArray(double[] array, double minBound, double maxBound)
    {
        double[] compressed = array.Where(x => x < minBound || x > maxBound).ToArray();
        return compressed.Concat(new double[array.Length - compressed.Length]).ToArray();
    }
}
