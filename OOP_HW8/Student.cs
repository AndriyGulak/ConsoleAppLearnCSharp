using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW8
{
    internal class Student : Person
    {

        public List<Courses> Courses { get; private set; }


        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            Courses = new List<Courses>();
        }

        public Student(string firstName, string lastName, DateTime dOB) : this(firstName, lastName)
        {
            DOB = dOB;
        }

        public Student(string firstName, string lastName, DateTime dOB, string city, List<Courses> Courses) : base(firstName, lastName, dOB, city)
        {
            this.Courses = Courses;
            foreach (var c in Courses) 
            {
                c.AddStudent(this);
            }
        }

        public override void GetInfo()
        {
            string city = (City == null) ? "Unknown" : City;
            //Console.WriteLine($"----- Student {FirstName} {LastName} information:");
            Console.WriteLine($"FirstName = {FirstName} | LastName = {LastName} | Age = {GetAge()} | City = {GetCity()} | Courses count = {GetCoursesCount()}");
        }

        public void GetInfo(bool showCourses)
        {
            GetInfo();
            if (showCourses) 
            {
                Console.WriteLine($"Courses:");
                PrintCourses(); 
            }
            Console.WriteLine();
        }
        public new void GetPersonInfo()
        {
            base.GetPersonInfo();  
        }

        public void PrintCourses()
        {
            foreach (var c in Courses)
            {
                c.GetInfo();
            }
        }

        public void AddCourse(Courses Course)
        {
            if (!Courses.Contains(Course)) 
            { 
                Courses.Add(Course);
                if (!Course.students.Contains(this)) { Course.AddStudent(this); }
            }
            else throw new InvalidCoursesException("Student already attend the course!");
        }

        public void RemoveCourse(Courses Course)
        {
            if (Courses.Contains(Course)) 
            { 
                Courses.Remove(Course);
                if (Course.students.Contains(this)) Course.RemoveStudent(this);
            }
            else throw new InvalidCoursesException("Student doesn't attend the course!");

        }

        public int GetCoursesCount()
        {
            return Courses.Count();
        }

    }
}
