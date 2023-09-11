using System.Data;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        // var date = new DateTime();
        //var date = new DateTime(2001, 03, 26);
        var date = DateTime.Now;

        Console.WriteLine("Complete: " + date);
        Console.WriteLine("Year: " + date.Year);
        Console.WriteLine("Month: " + date.Month);
        Console.WriteLine("Day: " + date.Day);
        Console.WriteLine("Hours: " + date.Hour);
        Console.WriteLine("Minutes: " + date.Minute);
        Console.WriteLine("Seconds: " + date.Second);
        Console.WriteLine("Day of week: " + (int)date.DayOfWeek);
        Console.WriteLine("Day of year: " + (int)date.DayOfYear);

        Console.WriteLine("========================\n");

        var formated = string.Format("{0:dd/MM/yyyy hh:mm:ss}", date);

        Console.WriteLine(formated);


    }
}