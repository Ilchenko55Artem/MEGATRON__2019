using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть від 1 до 20 слів через пробіл:");
        string input = Console.ReadLine();
        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Послідовність слів без повторень:");
        Console.WriteLine(string.Join(" ", words.Distinct()));

        Console.WriteLine("Слова, що зустрічаються тільки один раз:");
        var uniqueWords = words.GroupBy(w => w).Where(g => g.Count() == 1).Select(g => g.Key);
        Console.WriteLine(string.Join(" ", uniqueWords));
    }
}
