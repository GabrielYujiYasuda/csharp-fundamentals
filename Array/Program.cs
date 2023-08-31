internal class Program
{
    private static void Main(string[] args)
    {
        string aula01 = "Introdução computação";
        string aula02 = "Estrutura de dados";
        string aula03 = "Aprendendo dotnet";

        //string[] aulas = new string[]
        //{
        //    aula01, aula02, aula03
        //};

        string[] arr = new string[3];
        arr[0] = aula01;
        arr[1] = aula02;
        arr[2] = aula03;

        Console.WriteLine("First index: " + arr[0]);
        Console.WriteLine("Last index: " + arr[arr.Length -1]);

        Imprimir(arr);
    }

    static void Imprimir(string[] arr)
    {
        foreach (string s in arr)
        {
            Console.WriteLine(s);
        }
    }
}