using System;

namespace Day1
{
    class Emp
    {
        static internal string CompName;
        internal int Sabun;
        internal void GotoOffice()
        {
            Console.WriteLine("출근..");

        }
    }

    class EmpTest
    {
        static void Main()
        {
            Emp.CompName = "TopCredu";
            Emp e = new Emp();
            e.Sabun = 1;
            e.GotoOffice();
        }
    }
}