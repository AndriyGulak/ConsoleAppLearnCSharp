using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Cources
    {
    //        Create a course class and describe its main characteristics: course name, teacher name, course duration, number of students.
    //        Describe the following actions: Print (output basic information).
    //        Add a student to the course group(add one student to the number of students). 
        //public int Id { get; set; }
        public string Name { get; private set; }
        public int Duration { get; private set; } // min
        public string TeacherName { get; private set; }
        public int NumberOfStudent { get; private set; }

        public Cources(string name, int duration, string teacherName) 
        { 
            Name = name;
            Duration = duration;
            TeacherName = teacherName;
            NumberOfStudent = 0;
        }
        public void Print() 
        {
            Console.WriteLine($"CourceName = {Name} | CourceDuration = {Duration} min | TeacherName = {TeacherName} | NumberOfStudent = {NumberOfStudent}");
        }

        public void AddStudent ()
        {
            NumberOfStudent++;
        }
        public void RemoveStudent () 
        {
            if (NumberOfStudent > 0)
                NumberOfStudent--;
            else
                Console.WriteLine("Number of students can't be less than zero");
        } 

    }
}
