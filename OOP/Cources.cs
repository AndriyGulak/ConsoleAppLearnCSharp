using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Courses
    {
    //        Create a course class and describe its main characteristics: course name, teacher name, course duration, number of students.
    //        Describe the following actions: Print (output basic information).
    //        Add a student to the course group(add one student to the number of students). 
        //public int Id { get; set; }
        private string _name;
        public string Name 
        {
            get { return _name; } 
            set { _name = value; }
        
        }

        public int Duration { get; set; } // min
        public string TeacherName { get; set; }
        public int NumberOfStudent { get;  set; }

        public Courses(string name)
        {
            Name = name;
            Duration = 0;
            TeacherName = "";
            NumberOfStudent = 0;
        }

        public Courses(string name, int duration, string teacherName) : this(name)
        { 
            //Name = name;
            Duration = duration;
            TeacherName = teacherName;
            NumberOfStudent = 0;
        }
        public void Print() 
        {
            Console.WriteLine($"CourseName = {Name} | CourseDuration = {Duration} min | TeacherName = {TeacherName} | NumberOfStudent = {NumberOfStudent}");
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
