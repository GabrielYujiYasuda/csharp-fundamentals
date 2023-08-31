using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        string aula01 = "Introdução computação";
        string aula02 = "Estrutura de dados";
        string aula03 = "Aprendendo dotnet";

        //List<string> aulas = new List<string>()
        //{
        //    aula01, aula02, aula03
        //};

        var aulas = new List<string>();
        aulas.Add(aula01);
            aulas.Add(aula02);
            aulas.Add(aula03);
        aulas.Add("LAST");
        aulas.Add("LAST dotnet");


        Print(aulas);
        Console.WriteLine("");

        Console.WriteLine("First class: " + aulas.First());
        Console.WriteLine("Last class: " + aulas.Last());

        Console.WriteLine("First that contains: " 
            + aulas.First((aula) => aula.Contains("dotnet")));

        Console.WriteLine("Last that contains: "
            + aulas.Last((aula) => aula.Contains("LAST")));

        Console.WriteLine("Last that contains: "
            + aulas.FirstOrDefault((aula) => aula.Contains("Testing!!!")));

        aulas.Reverse();
        aulas.Reverse();

        //Removing the last index
        aulas.RemoveAt(aulas.Count - 1);
    }

    private static void Print(List<string> aulas)
    {
        aulas.ForEach((aula) => Console.WriteLine(aula));

        //for (int i = 0; i < aulas.Count; i++)
        //{
        //    Console.WriteLine(aulas[i]);
        //}

        //foreach (string s in aulas)
        //{
        //    Console.WriteLine(s);
        //}
    }
}