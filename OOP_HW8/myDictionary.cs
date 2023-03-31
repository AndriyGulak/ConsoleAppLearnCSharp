using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW8
{
    public static class MyDictionary
    {
         static Dictionary<int, string> NameDictionary = new()
         {
                { 1, "Liam" },
                { 2, "Olivia" },
                { 3, "Noah" },
                { 4, "Emma" },
                { 5, "Oliver" },
                { 6, "Charlotte" },
                { 7, "James" },
                { 8, "Ava" },
                { 9, "Lucas" },
                { 10, "Mia" }
            };
        static Dictionary<int, string> LastNameDictionary = new()
         {
                { 1, "Smith" },
                { 2, "Johnson" },
                { 3, "Williams" },
                { 4, "Brown" },
                { 5, "Jones" },
                { 6, "Garcia" },
                { 7, "Miller" },
                { 8, "Davis" },
                { 9, "Rodriguez" },
                { 10, "Martinez" }
            };

        static Random rnd = new Random();
        public static string GenName()
        {
            //Random rnd = new();
            int i = rnd.Next(1, 10);
            return (NameDictionary[i]).ToString();
        }

        public static string GenLastName()
        {
            //Random rnd = new();
            int i = rnd.Next(1, 10);
            return (LastNameDictionary[i]).ToString();
        }

        public static DateTime GenDOB()
        {
            DateTime start = new DateTime(1980, 1, 1);
            return start.AddDays(rnd.Next(6570, 12750));
        }

    }
}
