using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //StringConversion();
        //StringAsArray();
        ScapeString();
    }

    private static void StringConversion() 
    {
        string testString = "ThIs Is tHe FBI Calling!";
        string result;

        result = testString.ToLower();
        System.Console.WriteLine(result);

        result = testString.ToUpper();
        System.Console.WriteLine(result);
    }

    private static void StringAsArray()
    {
        string testString = "Gabriel Yasuda";

        for (int i = 0; i < testString.Length; i++)
        {
            System.Console.WriteLine(testString[i]);
        }
    }

    private static void ScapeString()
    {

    }
 }