using System;

namespace MyApp
{
/*    class Math
    {
        public static int abs() { return 0; }
    }*/
    internal class Program234
    {
        static void Main(string[] args)
        {
            Math.Abs(-3);
            OtherClass oc = new OtherClass();
            Console.WriteLine("Hello World!");
            List<Student> list = new List<Student>()
            {
                new Student() { name = "박나경", grade = 1 },
                new Student() { name = "김태연", grade = 2 },
                new Student() { name = "김하늘", grade = 3 },
                new Student() { name = "문채영", grade = 4 }
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===================");
            foreach (var item in list)
            {
                list.Remove(item); 
            
            
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        class ThirdClass
        {

        }
    }

    class SecondClass
    {

    }
}