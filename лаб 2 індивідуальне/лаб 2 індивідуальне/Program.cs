using System;
using System.Collections.Generic;

class Time
{
    public int Hours { get; private set; }
    public int Minutes { get; private set; }
    public int Seconds { get; private set; }

    public Time(int hours, int minutes, int seconds)
    {
        if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
            throw new ArgumentException("Некоректне значення часу!");
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public void SetTime(int hours, int minutes, int seconds)
    {
        if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
            throw new ArgumentException("Некоректне значення часу!");
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public override string ToString()
    {
        return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
    }
}

class TimeCollection
{
    private List<Time> times;

    public TimeCollection()
    {
        times = new List<Time>();
    }

    public TimeCollection(TimeCollection other)
    {
        times = new List<Time>(other.times);
    }

    public void AddTime(int hours, int minutes, int seconds)
    {
        times.Add(new Time(hours, minutes, seconds));
    }

    public void UpdateTime(int index, int hours, int minutes, int seconds)
    {
        if (index >= 0 && index < times.Count)
            times[index].SetTime(hours, minutes, seconds);
        else
            Console.WriteLine("Індекс поза межами списку!");
    }

    public void DisplayTimes()
    {
        for (int i = 0; i < times.Count; i++)
        {
            Console.WriteLine($"Час {i + 1}: {times[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        TimeCollection timeCollection = new TimeCollection();
        timeCollection.AddTime(12, 30, 45);
        timeCollection.AddTime(6, 15, 20);
        timeCollection.DisplayTimes();
        Console.WriteLine("Оновлення часу...");
        timeCollection.UpdateTime(1, 8, 20, 30);
        timeCollection.DisplayTimes();
        Console.ReadLine();
    }
}
