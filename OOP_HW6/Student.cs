using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW6
{
    internal class Student : Person
    {
        private Courses[]? _Courses = Array.Empty<Courses>();
        public Courses[] Courses
        {
            get { return _Courses; }
            set { _Courses = value; }
        }

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Student(string firstName, string lastName, DateTime dOB, string city, Courses[] Courses) : base(firstName, lastName, dOB, city)
        {
            foreach (var c in Courses)
            {
                c.AddStudent();
            }
            this.Courses = Courses;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"----------  Student Info----------");
            Console.WriteLine($"FirstName = {FirstName} \t LastName = {LastName}\t Age = {GetAge()} \t City = {City} \t Courses count = {Courses.Length}");
        }
        public new void GetPersonInfo()
        {
            base.GetPersonInfo();  
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

    }
}
