﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW6
{
    internal class Courses
    {
        private string _name = "";
        public string Name
        {
            get { return _name; }
            set { _name = value; } 

        }

        public int Duration { get; set; } // min
        public Teacher? Teacher { get; set; }

        public List<Student> students { get; set; }

        public Courses(string name)
        {
            Name = name;
            Duration = 0;
            Teacher = null;
            students = new List<Student>{ };
        }

        public Courses(string name, int duration, Teacher teacher) : this(name)
        {
            Duration = duration;
            Teacher = teacher;
            AddCourseToTeacher(teacher);
        }
        public void Print()
        {
            string teacherFullName = (Teacher == null) ? "Not assigned" : Teacher.FirstName + " " + Teacher.LastName;
            Console.WriteLine($"CourseName = {Name} | CourseDuration = {Duration} min | TeacherName = {teacherFullName} | NumberOfStudent = {GetStudentsCount()}");
        }

        public void AddStudent(Student student)
        {
            if (!students.Contains(student)) { students.Add(student); }
            if (!student.Courses.Contains(this)) { student.AddCourse(this); }
        }
        public void RemoveStudent(Student student)
        {
            if (students.Contains(student)) { students.Remove(student); }
            if (student.Courses.Contains(this)) { student.RemoveCourse(this); };
        }
        public int GetStudentsCount()
        {
            return students.Count();
        }

        public void AddCourseToTeacher(Teacher teacher)
        {
            teacher.AddCourse(this);
        }


    }
}
