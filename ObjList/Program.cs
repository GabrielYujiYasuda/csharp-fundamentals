using ObjList;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Aula aula01 = new Aula("Aprendendo Rust", 999);
        Aula aula02 = new Aula("Aprendendo Go", 12);
        Aula aula03 = new Aula("Aprendendo Java", 65);
        Aula aula04 = new Aula("Aprendendo Asp.net", 48);

        List<Aula> list = new List<Aula>();

        list.Add(aula01);
        list.Add(aula02);
        list.Add(aula03);
        list.Add(aula04);

        Imprimir(list);

        list.Sort();
        Imprimir(list);

        list.Sort((x, y) => x.time.CompareTo(y.time));
        Imprimir(list);
    }

    public static void Imprimir(List<Aula> list)
    {
        Console.Clear();
        
        list.ForEach(aula => Console.WriteLine(aula));
    }
}