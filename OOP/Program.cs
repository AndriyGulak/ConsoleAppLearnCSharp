namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var s1 = new Student("Andrii", "G", 18, "Kyiv");
            var s2 = new Student("Alona", "G", 16, "Kyiv");
            var s3 = new Student("Sasha", "P", 17, "Lviv");

            var c1 = new Cources("C# 1", 120, "Krystyna");
            var c2 = new Cources("C# 2", 110, "Krystyna");
            var c3 = new Cources("C# 3", 100, "Krystyna");
            var c4 = new Cources("TEST");

            c4.Print();

            s1.Print();

            Console.WriteLine("-----------------");
            Console.WriteLine(s1.Cources.Length);
            Console.WriteLine("-----------------");

            //c1.Print();
            //c1.AddStudent();
            //c1.Print();

            s1.AddCource(c1);
            s2.AddCource(c1);
            s3.AddCource(c1);

            Console.WriteLine("-----------------");
            c1.Print();
            Console.WriteLine("-----------------");


            s1.AddCource(c2);
            s1.AddCource(c3);
            Console.WriteLine("-----------------");
            s1.Print(true);




            //s1.RemoveCource(c1);
            s2.RemoveCource(c1);
            //s1.RemoveCource(c2);
            //s1.RemoveCource(c3);
            Console.WriteLine("--------AFTER REMOVE---------");
            s1.Print(true);

            Console.WriteLine("-------Student with cources----------");
            var s4 = new Student("Test", "P", 4, "City", new Cources[] {c1, c2, c3, c4 });
            s4.Print(true);



        }
    }
}