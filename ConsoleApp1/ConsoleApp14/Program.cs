using System;

namespace Day1
{
    class Emp
    {
        public String Name  //프로퍼티
        {
            get;
            set;
        }
    }
    class EmpTest
    { 
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            e1.Name = "홍길동";
            string name = e1.Name;
            Console.WriteLine(name);
        }
    }
}
