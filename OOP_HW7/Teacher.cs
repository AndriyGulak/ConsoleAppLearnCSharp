using System;
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
        public List<Cources> cources { get; set; } = new List<Cources> { };

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
                $" Speciality = {Speciality} | Cources count = {GetCourcesCount()} | Students count = {GetStudentsCount()}");
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

        public void AddCource(Cources cource)
        {
            if (!cources.Contains(cource)) 
            { 
                cources.Add(cource);
                cource.Teacher = this;
            }
        }
        public void RemoveCource(Cources cource)
        {
            if (cources.Contains(cource)) 
            { 
                cources.Remove(cource);
                cource.Teacher = null;
            }
        }

        public void PrintCources()
        {
            foreach (var c in cources)
            {
                c.Print();
            }
        }

        public int GetCourcesCount()
        {
            return cources.Count();
        }
    }
}
