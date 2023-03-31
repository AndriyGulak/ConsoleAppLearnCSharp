namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var s1 = new Student("Andrii", "G", 18, "Kyiv");
            var s2 = new Student("Alona", "G", 16, "Kyiv");
            var s3 = new Student("Sasha", "P", 17, "Lviv");

            var c1 = new Courses("C# 1", 120, "Krystyna");
            var c2 = new Courses("C# 2", 110, "Krystyna");
            var c3 = new Courses("C# 3", 100, "Krystyna");
            var c4 = new Courses("TEST");

            c4.Print();

            s1.Print();

            Console.WriteLine("-----------------");
            Console.WriteLine(s1.Courses.Length);
            Console.WriteLine("-----------------");

            //c1.Print();
            //c1.AddStudent();
            //c1.Print();

            s1.AddCourse(c1);
            s2.AddCourse(c1);
            s3.AddCourse(c1);

            Console.WriteLine("-----------------");
            c1.Print();
            Console.WriteLine("-----------------");


            s1.AddCourse(c2);
            s1.AddCourse(c3);
            Console.WriteLine("-----------------");
            s1.Print(true);




            //s1.RemoveCourse(c1);
            s2.RemoveCourse(c1);
            //s1.RemoveCourse(c2);
            //s1.RemoveCourse(c3);
            Console.WriteLine("--------AFTER REMOVE---------");
            s1.Print(true);

            Console.WriteLine("-------Student with Courses----------");
            var s4 = new Student("Test", "P", 4, "City", new Courses[] {c1, c2, c3, c4 });
            s4.Print(true);



        }
    }
}