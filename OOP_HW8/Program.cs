using System;
using System.Buffers.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using OOP_HW8;
using System.ComponentModel;

namespace OOP_HW8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //The purpose of homework is to finalize the project with students and teachers. Make sure that you have completed all of the listed functions or add them:
            //displaying all students on the screen(it is obligatory to display all courses for each student)
            //displaying all teachers(it is obligatory to display all courses for each teacher)
            //displaying all courses(for each course, display the teacher and all students)
            //write error handling
            //implement the ability to filter when linking students and a teacher by one field(for example, by name.If the name contains a string entered from the console, display these entities)

            var teacher1 = new Teacher("Krystyna", "Hurieieva");
            teacher1.Speciality = "Senior Software Engineer";

            var teacher2 = new Teacher("Anna", "Fomenko");
            teacher2.Speciality = "Language Consultant";


            var c1 = new Courses("C# 1", 120, teacher1);
            var c2 = new Courses("C# 2", 110, teacher1);
            //var c3 = new Courses("C# 3", 100, teacher1);
            var c3 = new Courses("C# 3");
            c3.Duration = 90;
            c3.AddCourseToTeacher(teacher1);

            var e1 = new Courses("English B1", 60, teacher2);
            var e2 = new Courses("French A1", 45, teacher2);

            teacher1.GetInfo(true);
            teacher2.GetInfo(true);

            //teacher1.PrintCourses();

            var students = new List<Student>();
            for (int i = 0; i < 10; i++) 
            {
                students.Add(new Student(MyDictionary.GenName(), MyDictionary.GenLastName(), MyDictionary.GenDOB()));
            }

            Console.WriteLine("");
            Console.WriteLine("===================");
            Console.WriteLine($"Input part of student's LastName to search student for course '{c1.Name}'");
            Console.WriteLine("Students:\n FirstName LastName Age");

            foreach (var s in students)
            {
                Console.WriteLine($"{s.FirstName}  {s.LastName}  {s.GetAge()}");
            }

            var searchStr = Console.ReadLine();

            var studentRes = students.Where(s => s.LastName.Contains(searchStr));
            foreach (var s in studentRes)
            {
                s.AddCourse(c1);
            }
            c1.GetInfo(true);


            //Console.WriteLine("PERSON ****************************************");
            //Person t1 = (Person)teacher1;
            //t1.GetPersonInfo();
            //teacher1.PrintCourses();

            var teacher3 = new Teacher("Test Name", "Test");
            var cSharpFull = new List<Courses> { c1, c2, c3 };
            teacher3.AddCourse(cSharpFull);
            teacher3.GetInfo(true);
            //teacher3.PrintCourses();


            teacher3.AddCourse(e1);
            teacher3.GetInfo(true);
            teacher1.GetInfo(true);

            var s1 = new Student("Andrii", "Gulak");
            //s1.Courses = new List<Courses> { e1 };
            s1.AddCourse(e1);


            var s2 = new Student("Sasha", "Pereverzev", new DateTime(1984, 1, 15), "Brovary", cSharpFull);
            s2.AddCourse(e1);


            try
            {
                e1.AddStudent(s2);
            }
            catch (InvalidPersonException e)
            {

                Console.WriteLine($"AddStudent method: {e.Message}");
            }
           
            //e1.AddStudent(c1);


            //Console.WriteLine(new string('*', 40));
            //s1.GetInfo(true);
            //s2.GetInfo(true);

            Console.WriteLine("Cuorces INFO ------------ short ----------");
            e1.GetInfo();
            Console.WriteLine("Cuorces INFO ------------ full ----------");
            e1.GetInfo(true);


            //Console.WriteLine("Cuorces INFO ------------BEFORE----------");
            //c1.Print();
            //c2.Print();
            //Console.WriteLine("Rem 1");    
            ////s2.RemoveCourse(c1);
            //s2.GetInfo();
            //Console.WriteLine("Cuorces INFO ------------AFTER----------");
            //c1.Print();
            //c2.Print();

            //Console.WriteLine("After Rem 1");

            //Console.WriteLine(new string('/', 40));
            //c1.Print();
            //c2.Print(); 
            //c3.Print();

            //Console.WriteLine("TEACHER 3 INFO ------------BEGORE----------");

            //teacher3.GetInfo();
            //teacher3.PrintCourses();

            //Console.WriteLine("TEACHER 3 INFO ------------AFTER----------");

            //teacher3.RemoveCourse(c1);

            //teacher3.GetInfo();
            //teacher3.PrintCourses();
            //Console.WriteLine("Course 1 INFO -/////////////////----------");

            //c1.Print();



            //c4.Print();

            //var p = new Person("P Name", "P Full name");
            //p.GetPersonInfo();
            //Person p1 = s2;

        }
    }
}