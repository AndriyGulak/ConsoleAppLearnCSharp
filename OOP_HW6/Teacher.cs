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

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
            
        }
        public Teacher(string firstName, string lastName, DateTime dOB, string city, string speciality) : base(firstName, lastName, dOB, city)
        {
            Speciality = speciality;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"----------  Teacher Info ----------");
            Console.WriteLine($"FirstName = {FirstName} \t LastName = {LastName}\t Age = {GetAge()} \t City = {City} \t Speciality = {Speciality}");
        }
    }
}
