using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW8
{
    internal class Teacher : Person
    {
        public string Speciality { get; set; } = "";
        public List<Student> students { get; private set; } = new List<Student> { };
        public List<Courses> Courses { get; private set; } = new List<Courses> { };

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
            
        }
        public Teacher(string firstName, string lastName, DateTime dOB, string city, string speciality, List<Student> students) : base(firstName, lastName, dOB, city)
        {
            Speciality = speciality;
            this.students = students;
        }

        public override void GetInfo()
        {
            //Console.WriteLine($"-----  Teacher {FirstName} {LastName} information:");
            Console.WriteLine($"FirstName = {FirstName} | LastName = {LastName} | Age = {GetAge()} | City = {GetCity()} | " +
                $" Speciality = {Speciality} | Courses count = {GetCoursesCount()} | Students count = {GetStudentsCount()}");
        }

        public void GetInfo(bool showCourses)
        {
            GetInfo();
            if (showCourses) 
            { 
                PrintCourses();
            }
            Console.WriteLine();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);

            if (!students.Contains(student)) { students.Add(student); }
        }
        public void RemoveStudent(Student student)
        {
            if (students.Contains(student)) { students.Remove(student); }
        }
        public int GetStudentsCount()
        {
            return students.Count();
        }

        public void AddCourse(Courses Course)
        {
            if (!Courses.Contains(Course)) 
            { 
                Courses.Add(Course);
                Course.Teacher = this;
            }
        }

        public void AddCourse(List<Courses> Course)
        {
            foreach (Courses c in Course)
            {
                AddCourse(c);
            }
        }

        public void RemoveCourse(Courses Course)
        {
            if (Courses.Contains(Course)) 
            { 
                Courses.Remove(Course);
                Course.Teacher = null;
            }
            // delete Course from another teacher ?????
        }

        public void PrintCourses()
        {
            foreach (var c in Courses)
            {
                c.GetInfo();
            }
        }

        public int GetCoursesCount()
        {
            return Courses.Count();
        }
    }
}
