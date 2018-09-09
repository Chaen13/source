using System;
namespace Delegate_EX2
{
    class Program
    {
        delegate void Deli(string s);
        static void Main(string[] args)
        {
            Deli d = (v) => Console.WriteLine(v);
            d.Invoke("OJC");

            Deli d1 = new Deli(d);
            d1.Invoke("OJC");

            Deli d2 = d;
            d2.Invoke("OJC");
        }
        static void d(string s)
        {
            Console.WriteLine(s);
        }
    }
}
