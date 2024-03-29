﻿using System;
using System.Buffers.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace OOP_HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  add a collection of students to the teacher
            //  add a collection of courses to the teacher
            //  add a collection of students to the course
            //  add a collection of courses to a student
            //  implement collection management methods(add, remove, get the number of elements in the collection)

            var teacher1 = new Teacher("Krystyna", "Hurieieva");
            teacher1.Speciality = "Senior Software Engineer";

            var teacher2 = new Teacher("Anna", "Fomenko");
            teacher2.Speciality = "Language Consultant";

            teacher1.PrintCourses();

            var c1 = new Courses("C# 1", 120, teacher1);
            var c2 = new Courses("C# 2", 110, teacher1);
            var c3 = new Courses("C# 3", 100, teacher1);
            teacher1.GetInfo();
            teacher1.PrintCourses();

            var teacher3 = new Teacher("Test Name", "Test");
            var cSharpFull = new List<Courses> { c1, c2, c3 };
            teacher3.Courses = cSharpFull;
            teacher3.GetInfo();
            teacher3.PrintCourses();


            var e1 = new Courses("English B1", 60, teacher2);


            var s1 = new Student("Andrii", "Gulak");
            s1.Courses = new List<Courses> { e1 };
            var s2 = new Student("Sasha", "Pereverzev", new DateTime(1984, 1, 15), "Brovary", cSharpFull);


            Console.WriteLine(new string('*', 40));
            s1.GetInfo();
            s2.GetInfo();

            Console.WriteLine("Cuorces INFO ------------BEFORE----------");
            c1.Print();
            c2.Print();
            Console.WriteLine("Rem 1");    
            //s2.RemoveCourse(c1);
            s2.GetInfo();
            Console.WriteLine("Cuorces INFO ------------AFTER----------");
            c1.Print();
            c2.Print();

            Console.WriteLine("After Rem 1");

            Console.WriteLine(new string('/', 40));
            c1.Print();
            c2.Print(); 
            c3.Print();

            Console.WriteLine("TEACHER 3 INFO ------------BEGORE----------");

            teacher3.GetInfo();
            teacher3.PrintCourses();

            Console.WriteLine("TEACHER 3 INFO ------------AFTER----------");

            teacher3.RemoveCourse(c1);

            teacher3.GetInfo();
            teacher3.PrintCourses();
            Console.WriteLine("Course 1 INFO -/////////////////----------");

            c1.Print();



            //c4.Print();

            //var p = new Person("P Name", "P Full name");
            //p.GetPersonInfo();
            //Person p1 = s2;

        }
    }
}