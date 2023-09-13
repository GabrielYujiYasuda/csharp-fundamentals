using System.Globalization;

namespace CultureInfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pt = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");

            CultureInfo currently = CultureInfo.CurrentCulture;

            var utcDate = DateTime.UtcNow;
            Console.WriteLine(utcDate);

            Console.WriteLine(DateTime.Now.ToString("d", de));
        }
    }
}