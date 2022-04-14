using System;

namespace Access_Md
{
    public class Program
    {
        public void Test1()
        {
            Console.WriteLine("Public Method");
        }
        private void Test2()
        {
            Console.WriteLine("Private Method");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected Method");
        }
        internal void Test4()
        {
            Console.WriteLine("Internal Method");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Program p1 = new Program();
            p1.Test1();
            p1.Test2();
            p1.Test3();
            p1.Test4();
        }
    }
}