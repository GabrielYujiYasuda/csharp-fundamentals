using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjList
{
    public class Aula : IComparable
    {
        string Title { get; set; }
        public int Time { get; set; }

        public Aula(string title, int time)
        {
            Title = title;
            Time = time;
        }

        public override string ToString()
        {
            return $"Title: {Title}\n Time: {Time}\n";
        }

        public int CompareTo(object? obj)
        {
            Aula? temp = obj as Aula;

            return Title.CompareTo(temp.Title);
        }
    }
}
