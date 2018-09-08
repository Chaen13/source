using System;
namespace day2
{
    internal abstract class Dog
    {
        public string name { get; set; }
        public abstract void jitda();
    }
    internal class Pudle : Dog
    {
        public void work()
        {
            Console.WriteLine(name + "가 일한다.");
        }
        public override void jitda()
        {
            Console.WriteLine("캉캉");
        }
    }
    internal class Jindo : Dog
    {
        public void Run()
        {
            Console.WriteLine(name + "가 달린다.");
        }
        public override void jitda()
        {
            Console.WriteLine("왈왈");
        }
    }
    class DogManager
    {
        static void Main(string[] args)
        {
            Dog dogPudle = new Pudle();
            dogPudle.name = "푸딩";
            dogPudle.jitda();
            ((Pudle)dogPudle).work();

            Dog dogJindo = new Jindo();
            dogJindo.name = "진저";
            ((Jindo)dogJindo).Run();
            dogJindo.jitda();
        }

        //void a(Pudle p) { }
        //void a(Jindo j) { }
        void a(Dog d) { }
    }
}
