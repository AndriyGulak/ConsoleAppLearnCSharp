using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW6
{
    internal class Student : Person
    {

        public List<Cources> cources { get; set; }


        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
            cources = new List<Cources>();
        }

        public Student(string firstName, string lastName, DateTime dOB, string city, List<Cources> cources) : base(firstName, lastName, dOB, city)
        {
            this.cources = cources;
            foreach (var c in cources) 
            {
                c.AddStudent(this);
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine($"----------  Student Info----------");
            Console.WriteLine($"FirstName = {FirstName} | LastName = {LastName} | Age = {GetAge()} | City = {City} | Cources count = {cources.Count()}");
        }
        public new void GetPersonInfo()
        {
            base.GetPersonInfo();  
        }

        public void PrintCources()
        {
            foreach (var c in cources)
            {
                c.Print();
            }
        }

        public void AddCource(Cources cource)
        {
            if (!cources.Contains(cource)) { cources.Add(cource); }
            if (!cource.students.Contains(this)) { cource.AddStudent(this); }
        }

        public void RemoveCource(Cources cource)
        {
            if (cources.Contains(cource)) { cources.Remove(cource); };
            if (cource.students.Contains(this)) cource.RemoveStudent(this);
        }

        public int GetCourcesCount()
        {
            return cources.Count();
        }

    }
}
