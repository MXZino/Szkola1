using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaBartoszGulatowski
{
    class Student
    {
        private string firstName;
        private string secondName;
        private int id = 0;
        private Class Classname;

        public Student(string firstName, string secondName, Class classname)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.Classname = classname;
        }

        public override string ToString()
        {
            return firstName + " " + secondName + " " + " Numer w dzienniku: "+ id + " Klasa: " + Classname.GetName();

        }
        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public Class GetClassname()
        {
            return Classname;
        }
    }
}
