using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //Par
        HashSet<int> evenNumbers = new HashSet<int>();

        //Ímpar
        HashSet<int> oddNumbers = new HashSet<int>();

        for (int i = 0; i < 5; i++)
        {
            evenNumbers.Add(i * 2);
            oddNumbers.Add((i * 2) + 1);
        }

        Console.WriteLine("Even numbers: ");
        foreach (int i in evenNumbers)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
        Console.WriteLine("Odd numbers: ");
        foreach (int i in oddNumbers)
        {
            Console.WriteLine(i);
        }
    }
}