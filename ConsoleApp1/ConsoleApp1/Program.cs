using System;

namespace ConsoleApp1
{
    class Emp
    {
        public int sabun;             //멤버, 인스턴스변수
        public string irum;
        public void GotoOffice()   //멤버, 메소드
        {
            Console.WriteLine("사원출근~");
        }
    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.sabun = 1;
            e.irum = "홍길동";
            e.GotoOffice();
        }
    }
}
