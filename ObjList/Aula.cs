using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjList
{
    public class Aula : IComparable
    {
        string title { get; set; }
        public int time { get; set; }

        public Aula(string title, int time)
        {
            this.title = title;
            this.time = time;
        }

        public override string ToString()
        {
            return $"Title: {title}\n Time: {time}\n";
        }

        public int CompareTo(object? obj)
        {
            Aula? temp = obj as Aula;

            return title.CompareTo(temp.title);
        }
    }
}
