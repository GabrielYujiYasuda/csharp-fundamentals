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
        //Comparing
        string text01 = "Test";

        Console.WriteLine("Comparing: " + text01.CompareTo("Test"));
        Console.WriteLine("Contains: " + text01.Contains("test", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Contains: " + text01.Contains("tste"));
    }
}