using System;

struct Date
{
    public int Year, Month, Day;

    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public static int DifferenceInDays(Date d1, Date d2)
    {
        DateTime date1 = new DateTime(d1.Year, d1.Month, d1.Day);
        DateTime date2 = new DateTime(d2.Year, d2.Month, d2.Day);
        return Math.Abs((date2 - date1).Days);
    }
}

class Program
{
    static void Main()
    {
        Date date1 = ReadDate("Введіть першу дату (рік місяць день): ");
        Date date2 = ReadDate("Введіть другу дату (рік місяць день): ");
        Console.WriteLine($"Різниця між датами: {Date.DifferenceInDays(date1, date2)} днів");
    }

    static Date ReadDate(string message)
    {
        Console.Write(message);
        string[] input = Console.ReadLine().Split();
        return new Date(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]));
    }
}
