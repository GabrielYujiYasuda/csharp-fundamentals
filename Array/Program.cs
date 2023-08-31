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

        Console.WriteLine("The last index again: " + Array.LastIndexOf(arr, aula03));
        //reversing the array
        Array.Reverse(arr);
        Array.Resize(ref arr, 2);
        Array.Resize(ref arr, 3);

        arr[arr.Length - 1] = "AAA";

        Array.Sort(arr);

        string[] copyArr = new string[2];
        Array.Copy(arr, 1, copyArr, 0, 2);

        string[] cloneArr = arr.Clone() as string[];


        Console.WriteLine("");
        Imprimir(arr);
        Console.WriteLine("");
        Imprimir(copyArr);
        Console.WriteLine("");
        Imprimir(cloneArr);
    }

    static void Imprimir(string[] arr)
    {
        foreach (string s in arr)
        {
            Console.WriteLine(s);
        }

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.WriteLine(arr[i]);
        //}
    }
}