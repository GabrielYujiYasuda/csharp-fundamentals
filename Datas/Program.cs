using System.Data;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        // var date = new DateTime();
        //var date = new DateTime(2001, 03, 26);
        DateTime date = DateTime.Now;

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

        // var formated = string.Format("{0:dd/MM/yyyy hh:mm:ss}", date);
        // string formated = string.Format("{0:g}", date);
        string formated = string.Format("{0:r}", date);

        date.AddDays(13);
        date.AddMonths(3);
        date.AddYears(2);
        date.AddHours(23);

        Console.WriteLine(formated);

        Console.WriteLine("========================\n");

        var testx = DateTime.Now;

        if (testx.Date == DateTime.Now.Date)
        {
            Console.WriteLine("Same hours");
        } else
        {
            Console.WriteLine("Different hours!!!");
        }
    }
}