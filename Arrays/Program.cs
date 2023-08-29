using Microsoft.VisualBasic.FileIO;
using System.Collections;

int[] arr = new int[10];
Console.WriteLine(arr.Length);

Array.Resize(ref arr, 20);
Console.WriteLine(arr.Length);

ArrayList al = new ArrayList();
al.Add(100);
al.Add(200);
al.Add(300);
al.Add(400);
al.Add(500);

Console.WriteLine("AL capacity: " + al.Capacity);

foreach(object x in al)
{
    Console.Write(x + "   ");
}
Console.WriteLine(  );

al.Insert(1, 150);
al.Remove(200);
al.RemoveAt(0);

foreach (object x in al)
{
    Console.Write(x + "   ");
}

//You NEVER can do on arrays:
//- icrease the size
//- insert values in the middle 
//- delete or remove values from the middle