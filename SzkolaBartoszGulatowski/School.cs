using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaBartoszGulatowski
{
    class School
    {
        public List<Class> Classes = new List<Class>();
        public List<Student> Students = new List<Student>();

        public void AddAClass(Class classes)
        {
            Classes.Add(classes);
        }

        public void AddAStudent(Student student)
        {
            Students.Add(student);
        }

       
    }
}
