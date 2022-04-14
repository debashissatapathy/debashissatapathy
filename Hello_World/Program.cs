using System;

namespace Hello_World
{
    class First
    {
        public void studentData()
        {
            Console.WriteLine("This is first class file");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            First first = new First();
            first.studentData();

        }
    }
}
