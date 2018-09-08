using System;

namespace interfaceTest
{
    interface Dog
    {
        string name { get; set; }
        void jitda();   //추상메소드
    }
    class Pudle : Dog
    {
        public string name { get; set; }
        public void Work()
        {
            Console.WriteLine(name + "일한다.");
        }
        public void jitda()
        {
            Console.WriteLine(name + "짖다.");
        }
    }
    class Jindo : Dog
    {
        public string name { get; set; }
        public void Run()
        {
            Console.WriteLine(name + "달린다.");
        }
        public void jitda()
        {
            Console.WriteLine(name + "짖다.");
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            Dog p = new Pudle();
            p.name = "푸들이";
            p.jitda();
            ((Pudle)p).Work();

            Dog J = new Jindo();
            J.name = "진도";
            J.jitda();
            ((Jindo)J).Run();
        }
    }
}
