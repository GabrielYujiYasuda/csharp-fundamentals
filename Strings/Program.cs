internal class Program
{
    private static void Main(string[] args)
    {
        //var id = Guid.NewGuid();

        var price = 12.5432;

        //string text = "The price of the product is: " + price + "!Promo!";
        //string text = string.Format("The price of produts is {0:0.000} !PROMO!", price);
        string text = $@"The price of the product is: {price} !PROMO!";
        Console.WriteLine(text);

        Console.WriteLine();

        string text01 = "This is just a example for test";

        Console.WriteLine("Comparing: " + text01.CompareTo("Test"));
        Console.WriteLine("Contains: " + text01.Contains("test", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine();
        Console.WriteLine("Stars: " + text01.StartsWith("t", StringComparison.OrdinalIgnoreCase)); //Ignore cases
        Console.WriteLine("Ends: " + text01.EndsWith("G"));

        Console.WriteLine();
        Console.WriteLine("Equals: " + text01.Equals("Test"));
        Console.WriteLine("Equals: " + text01.Equals("test"));

        Console.WriteLine();
        Console.WriteLine("Index: " + text01.IndexOf("T"));
        Console.WriteLine("Index: " + text01.IndexOf("t"));

        Console.WriteLine();
        Console.WriteLine("Last index of: " +text01.LastIndexOf("i"));

        Console.WriteLine();
        string myName = "GaBrIeL YaSuDa";

        Console.WriteLine("Default: " + myName);
        Console.WriteLine("Upper: " + myName.ToUpper());
        Console.WriteLine("Lower: " + myName.ToLower());

        Console.WriteLine();
        string exploring = "Testing the remove and inserting";

        Console.WriteLine("Insert: " + exploring.Insert(0, "GABRIEL is "));
        Console.WriteLine("Remove: " + exploring.Remove(0, 8));

        Console.WriteLine();
        string replacing = "Gabriel Yasuda";

        //Console.WriteLine(replacing.Replace("Yasuda", "Yuji"));
        replacing = replacing.Replace("Yasuda", "Yuji");
        Console.WriteLine(replacing);

    }
}