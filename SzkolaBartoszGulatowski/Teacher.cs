using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaBartoszGulatowski
{
    class Teacher
    {
        private string firstName;
        private string secondName;

        private List<Subject> subjects = new List<Subject>();

        public Teacher(string firstName, string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }


        public void AddASubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public void SetFirstName(string name)
        {
            this.firstName = name;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public void SetSecondName(string name)
        {
            this.secondName = name;
        }

        public string GetSecondName()
        {
            return this.secondName;
        }

        public Subject GetSubject(int i)
        {
            return subjects[i];
        }

        public int SubjectsCount()
        {
            return subjects.Count();
        }

    }
}
