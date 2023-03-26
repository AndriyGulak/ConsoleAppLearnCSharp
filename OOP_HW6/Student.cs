using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW6
{
    internal class Student : Person
    {
        private Cources[]? _cources = Array.Empty<Cources>();
        public Cources[] Cources
        {
            get { return _cources; }
            set { _cources = value; }
        }

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Student(string firstName, string lastName, DateTime dOB, string city, Cources[] cources) : base(firstName, lastName, dOB, city)
        {
            foreach (var c in cources)
            {
                c.AddStudent();
            }
            Cources = cources;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"----------  Student Info----------");
            Console.WriteLine($"FirstName = {FirstName} \t LastName = {LastName}\t Age = {GetAge()} \t City = {City} \t Cources count = {Cources.Length}");
        }
        public void PrintCources()
        {
            if (Cources.Length > 0)
            {
                foreach (var c in Cources)
                {
                    c.Print();
                }
                Console.WriteLine(new string('_', 30));

            }
            else
            {
                Console.WriteLine("Courses don't found!");
            }
        }

        public void AddCource(Cources cource)
        {
            Cources[] c = Cources;

            if (Cources.Length == 0)
            {
                Cources = new Cources[1] { cource };
                cource.AddStudent();
            }
            else
            {
                Array.Resize(ref c, Cources.Length + 1);
                c[Cources.Length] = cource;
                Cources = c;
                cource.AddStudent();
            }
        }

        public void RemoveCource(Cources cource)
        {

            var index = Array.IndexOf(Cources, cource);
            Cources[] c = Cources;

            for (int i = index; i < c.Length - 1; i++)
            {
                c[i] = c[i + 1];
            }
            Array.Resize(ref c, c.Length - 1);
            Cources = c;
            cource.RemoveStudent();
        }

    }
}
