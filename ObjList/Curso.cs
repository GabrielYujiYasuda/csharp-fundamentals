using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjList
{
    internal class Curso
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public List<Aula>? Aulas { get;  set; }

        public Curso(string name, string teacher, List<Aula> aulas)
        {
            Name = name; 
            Teacher = teacher;
            Aulas = aulas;
        }

        public int TotalTime()
        {
            return Aulas.Sum(aula => aula.Time);
        }
    }
}
