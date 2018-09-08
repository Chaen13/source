using System;
namespace AsTest
{
    class Emp : System.Object
    {
        public override string ToString()
        {
            return "Emp";
        }
    }

    class Programmer : Emp
    { }

    class Program
    {
        static void Main(string[] args)
        {
            Programmer pmr = new Programmer();
            Emp e = pmr as Emp;
            if (e != null)
                Console.WriteLine(e);    //ToString() 안쓰고 객체만 써도 ToString() 호출이됨.

            Emp e2 = new Programmer();
            if (e2 != null)
                Console.WriteLine(e2.ToString());
        }
    }
}