using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW6
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get;  set; } = DateTime.MinValue;
        public string? City { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, DateTime dob, string city) : this(firstName, lastName)
        {
            DOB = dob;
            City = city;
        }

        public int GetAge()
        { 
            if (DOB == DateTime.MinValue)
            { 
                return 0; 
            }   

            return DateTime.Now.Year - DOB.Year;   
        }
        public virtual void GetInfo()
        {

        }

        public void GetPersonInfo()
        {
            Console.WriteLine($"----------  Person Info----------");
            Console.WriteLine($"FirstName = {FirstName} \t LastName = {LastName}\t Age = {GetAge()} \t City = {City}");
        }
    }
}
