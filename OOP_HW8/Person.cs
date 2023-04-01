using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW8
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get;  set; } = DateTime.MinValue;
        public string? City { get; set; }

        public Person(string firstName, string lastName)
        {
            if (firstName == "" || lastName == "")
                throw new InvalidPersonException("Name or LastName can't be empty");
            else 
            {
                FirstName = firstName;
                LastName = lastName;
            }
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

        public string GetCity()
        {
            return City ?? "Unknown";
        }
        public virtual void GetInfo() { }

        public void GetPersonInfo()
        {
            string city = City ?? "Unknown";
            //Console.WriteLine($"----- Person {FirstName} {LastName} information:");
            Console.WriteLine($"FirstName = {FirstName} | LastName = {LastName} | Age = {GetAge()} | City = {GetCity()}");
        }
    }
}
