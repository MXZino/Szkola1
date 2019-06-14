using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaBartoszGulatowski
{
    class Class
    {
        private string name;
        private List<Teacher> Teachers = new List<Teacher>();

        public Class(string name)
        {
            this.name = name;
            
        }

        public void AddATeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public Teacher GetTeacher(int i)
        {
            return Teachers[i];
 
        }

        public int TeachersCount()
        {
            return Teachers.Count();
        }
    }
}
