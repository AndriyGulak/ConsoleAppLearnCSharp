using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP
{
    internal class Student
    {
        // Create a student class and describe its main characteristics: First name, last name, age, city, courses attended (an array of courses).
        /*
        Describe the following actions: Print (output basic information).
        Add one course to the student (add a new course to the course array).
        Delete a course from a student.

        Create a course class and describe its main characteristics: course name, teacher name, course duration, number of students.
        Describe the following actions: Print (output basic information).
        Add a student to the course group (add one student to the number of students). 


        for each of the classes create a chain of calling constructors.



        */
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string City { get; private set; }


        private Courses[] _Courses = Array.Empty<Courses>();
        public Courses[] Courses
        {
            get { return _Courses; }
            set { _Courses = value; }
        }

        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public Student(string firstName, string lastName, int age, string city, Courses[] Courses) : this(firstName, lastName, age, city)
        {
            _Courses = Courses;
            Courses = Courses;
        }

        public void Print(bool showCourses = false)
        {
            Console.WriteLine($"FirstName = {FirstName}");
            Console.WriteLine($"LastName  = {LastName}");
            Console.WriteLine($"Age       = {Age}");
            Console.WriteLine($"City      = {City}");
            if(showCourses) 
                    PrintCourses();
        }

        public void PrintCourses()
        {
            if (Courses.Length > 0)
            {
                foreach (var c in Courses)
                {
                    c.Print();
                }
                Console.WriteLine(new string('_', 30));

            }
            else
            {
                Console.WriteLine("Courses don't found!");
            }
        }

        public void AddCourse(Courses Course)
        {
            Courses[] c = Courses;

            if (Courses.Length == 0)
            {
                Courses = new Courses[1] { Course };
                Course.AddStudent();
            }
            else
            {
                Array.Resize(ref c, Courses.Length + 1);
                c[Courses.Length] = Course;
                Courses = c;
                Course.AddStudent();
            }
        }

        public void RemoveCourse(Courses Course)
        {

            var index = Array.IndexOf(Courses, Course);
            Courses[] c = Courses;

            for (int i = index; i < c.Length - 1; i++)
            {
                c[i] = c[i + 1];
            }
            Array.Resize(ref c, c.Length - 1);
            Courses = c;
            Course.RemoveStudent();
        }

        public void AddCourse(string CourseName)
        {
            //
        }


        public void RemoveCourse(string CourseName)
        {
            //
        }
    }
}
