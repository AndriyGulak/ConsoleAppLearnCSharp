﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW6
{
    internal class Teacher : Person
    {
        public string Speciality { get; set; } = "";
        public List<Student> students { get; set; } = new List<Student> { };
        public List<Courses> Courses { get; set; } = new List<Courses> { };

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
            Console.WriteLine($"----------  Teacher Info ----------");
            Console.WriteLine($"FirstName = {FirstName} | LastName = {LastName} | Age = {GetAge()} | City = {City} | " +
                $" Speciality = {Speciality} | Courses count = {GetCoursesCount()} | Students count = {GetStudentsCount()}");
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
        public void RemoveCourse(Courses Course)
        {
            if (Courses.Contains(Course)) 
            { 
                Courses.Remove(Course);
                Course.Teacher = null;
            }
        }

        public void PrintCourses()
        {
            foreach (var c in Courses)
            {
                c.Print();
            }
        }

        public int GetCoursesCount()
        {
            return Courses.Count();
        }
    }
}
