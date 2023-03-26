using System;
using System.Buffers.Text;

namespace OOP_HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Based on the work that was done in homework 5: 
            // add class Teacher. The Student class and the Teacher class must have a common base class from which they will be inherited.
            // In the base class (from the previous paragraph) add the Describe Yourself method. (Alternative print) 
            // Override the Describe Yourself method in the Student class and in the Teacher class.

            var teacher = new Teacher("Krystyna", "Hurieieva");

            var c1 = new Cources("C# 1", 120, teacher);
            var c2 = new Cources("C# 2", 110, teacher);
            var c3 = new Cources("C# 3", 100, teacher);
            var c4 = new Cources("English");

            var cSharpFullCource = new Cources[3] { c1, c2, c3 }; 

            var s1 = new Student("Andrii", "Gulak");
            var s2 = new Student("Sasha", "Pereverzev", new DateTime(1984, 1, 15), "Brovary", cSharpFullCource);


            teacher.GetInfo();

            Console.WriteLine(new string('*', 40));
            s1.GetInfo();
            s2.GetInfo();

            Console.WriteLine(new string('*', 40));
            c1.Print();
            c2.Print(); 
            c3.Print();

            c4.Print();

        }
    }
}