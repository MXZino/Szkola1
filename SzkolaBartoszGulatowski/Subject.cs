using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaBartoszGulatowski
{
    public class Subject
    {
        private string name;
        private int lessons;
        private int excercises;

        public Subject(string name, int lessons, int excercises)
        {
            this.name = name;
            this.lessons = lessons;
            this.excercises = excercises;
        }

        public string GetName()
        {
            return name;
        }

        public int GetLessons()
        {
            return lessons;
        }

        public int GetExcercises()
        {
            return excercises;
        }
        public override string ToString()
        {
            return name + " Liczba lekcji: " + lessons + " Liczba ćwiczeń: " + excercises;
        }
    }
}
