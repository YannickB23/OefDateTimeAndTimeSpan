using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlas
{
    class Program
    {
        static Random number = new Random();
        static void Main(string[] args)
        {
            //DECLARATIONS
            string[] names = { "Hanne", "Vic", "Hilde", "Yannick" };
            DateTime[] birthdates = new DateTime[4];
            TimeSpan[] ageDiff;
            int index;
            bool stop;
            //INPUT
            for (int i = 0; i < birthdates.Length; i++)
            {
                birthdates[i] = GenerateBirthday();
            }
            //PROCESSING
            do
            {
                Console.Clear();
                ShowPeople(names);
                Console.WriteLine("Who do you want to compare with the rest? (-1 to quit)");
                index = int.Parse(Console.ReadLine());
                if (index != -1)
                {
                    ageDiff = CompareBirthdates(birthdates, index);
                    ShowAgeDifferences(ageDiff, names, index);
                    Console.ReadLine();
                    stop = true;
                }
                else
                {
                    Console.WriteLine("App gaat sluiten");
                    stop = false;
                }
                while (stop)
                ageDiff = CompareBirthdates(birthdates, index);
                ShowAgeDifferences(ageDiff, names, index);
            }
        }
    }
    private static void ShowAgeDifferences(TimeSpan[] ageDiff, string[] names, int index)
    {
        for (int i = 0; i < names.Length; i++)
        {
            if (index == i)
                continue;
            else if (ageDiff[i].Days<0)
                Console.WriteLine($"{names[index] is { Math.Abs(ageDiff[i].Days) } dagen ouder dan {names[i]}.");


        }
    }
    private static TimeSpan[] CompareBirthdates(DateTime[] birthdates, int index)
    {
        TimeSpan[] differences = new TimeSpan[birthdates.Length];
        for (int i = 0; i < birthdates.Length; i++)
        {
            differences[i] = birthdates[index] - birthdates[i];
        }
        return differences;
    }

    private static void ShowPeople(string[] names)
    {
        Console.WriteLine("Kies een persoon: ");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{i}.\t{names[i]}");
        }

    }
    private static DateTime GenerateBirthday()
    {
        int year, month, day;
        year = number.Next(1980, 2020);
        month = number.Next(13);
        day = number.Next(25);
        return new DateTime(year, month, day);
    }
}

