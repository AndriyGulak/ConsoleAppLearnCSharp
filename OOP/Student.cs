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
        */
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string City { get; private set; }

        private Cources[] _cources = Array.Empty<Cources>();
        public Cources[] Cources
        {
            get { return _cources; }
            set { _cources = value; }
        }

        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public void Print(bool showCources = false)
        {
            Console.WriteLine($"FirstName = {FirstName}");
            Console.WriteLine($"LastName  = {LastName}");
            Console.WriteLine($"Age       = {Age}");
            Console.WriteLine($"City      = {City}");
            if(showCources) 
                    PrintCources();
        }

        public void PrintCources()
        {
            if (Cources.Length > 0)
            {
                foreach (var c in Cources)
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

        public void AddCource(Cources cource)
        {
            Cources[] c = Cources;

            if (Cources.Length == 0)
            {
                Cources = new Cources[1] { cource };
                cource.AddStudent();
            }
            else
            {
                Array.Resize(ref c, Cources.Length + 1);
                c[Cources.Length] = cource;
                Cources = c;
                cource.AddStudent();
            }
        }

        public void RemoveCource(Cources cource)
        {

            var index = Array.IndexOf(Cources, cource);
            Cources[] c = Cources;

            for (int i = index; i < c.Length - 1; i++)
            {
                c[i] = c[i + 1];
            }
            Array.Resize(ref c, c.Length - 1);
            Cources = c;
            cource.RemoveStudent();
        }

        public void AddCource(string courceName)
        {
            //
        }


        public void RemoveCource(string courceName)
        {
            //
        }
    }
}
