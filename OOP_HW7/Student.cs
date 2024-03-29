﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW6
{
    internal class Student : Person
    {

        public List<Courses> Courses { get; set; }


        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            Courses = new List<Courses>();
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
            Console.WriteLine($"----------  Student Info----------");
            Console.WriteLine($"FirstName = {FirstName} | LastName = {LastName} | Age = {GetAge()} | City = {City} | Courses count = {Courses.Count()}");
        }
        public new void GetPersonInfo()
        {
            base.GetPersonInfo();  
        }

        public void PrintCourses()
        {
            foreach (var c in Courses)
            {
                c.Print();
            }
        }

        public void AddCourse(Courses Course)
        {
            if (!Courses.Contains(Course)) { Courses.Add(Course); }
            if (!Course.students.Contains(this)) { Course.AddStudent(this); }
        }

        public void RemoveCourse(Courses Course)
        {
            if (Courses.Contains(Course)) { Courses.Remove(Course); };
            if (Course.students.Contains(this)) Course.RemoveStudent(this);
        }

        public int GetCoursesCount()
        {
            return Courses.Count();
        }

    }
}
