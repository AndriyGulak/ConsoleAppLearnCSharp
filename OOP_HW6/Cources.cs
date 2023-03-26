using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW6
{
    internal class Cources
    {
        private string _name = "";
        public string Name
        {
            get { return _name; }
            set { _name = value; } 

        }

        public int Duration { get; set; } // min
        public Teacher? Teacher { get; set; }
        public int NumberOfStudent { get; set; }

        public Cources(string name)
        {
            Name = name;
            Duration = 0;
            Teacher = null;
            NumberOfStudent = 0;
        }

        public Cources(string name, int duration, Teacher teacher) : this(name)
        {
            Duration = duration;
            Teacher = teacher;
            NumberOfStudent = 0;
        }
        public void Print()
        {
            string teacherFullName = (Teacher == null) ? "Not assigned" : Teacher.FirstName + " " + Teacher.LastName;
            Console.WriteLine($"CourceName = {Name} | CourceDuration = {Duration} min | TeacherName = {teacherFullName} | NumberOfStudent = {NumberOfStudent}");
        }

        public void AddStudent()
        {
            NumberOfStudent++;
        }
        public void RemoveStudent()
        {
            if (NumberOfStudent > 0)
                NumberOfStudent--;
            else
                Console.WriteLine("Number of students can't be less than zero");
        }
    }
}
