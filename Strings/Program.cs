using System.Text;

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
        Console.WriteLine(replacing.Replace("Yuji", "aspiodjaosipdj"));

        string texted = "     this,is,a,string,to,be,splited,just,for,fun      ";
        var splited = texted.Split(",");

        Console.WriteLine("SPLIT: " + splited);
        Console.WriteLine(splited[0]);
        Console.WriteLine(splited[1]);
        Console.WriteLine(splited[2]);
        Console.WriteLine(splited[3]);
        Console.WriteLine(splited[4]);
        Console.WriteLine(splited[5]);

        Console.WriteLine();

        Console.WriteLine("ITERATING");

        foreach (var item in splited)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("SubString: ");

        //Get the "fun" word;
        string result = texted[..4];
        Console.WriteLine(texted);
        Console.WriteLine("Result: " + result);

        Console.WriteLine(texted.Trim());

        Console.WriteLine();
        Console.WriteLine("STRING BUILDER: ");

        var texto = new StringBuilder();
        texto.Append("TEXTO TEXTO TEXTO TEXTO TEXTO TEXTO");
        texto.Append("Gabriel Yasuda");

        Console.WriteLine(texto.ToString());

    }
}