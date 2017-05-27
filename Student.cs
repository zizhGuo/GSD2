using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevationMaster
{
    internal class Student
    {
        int id;
        int grades;
        internal Student(int id, int grades)
        {
            this.id = id;
            this.grades = grades;
        }
        public static Student operator +(Student a, Student b)
        {
            Student student = new Student(a.id + b.id, a.grades + b.grades);
            //student.id = a.id + b.id;
            //student.grades = a.grades + b.grades;
            return student;          
            
        }
        public static implicit operator int(Student a)
        {
            return a.grades;
        }
        public void Display()
        {
            Console.WriteLine("id: {0}\ngrades: {1}", id, grades);
        }


    }
}
