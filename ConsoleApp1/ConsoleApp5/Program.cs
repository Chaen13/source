using System;
using System.Runtime.InteropServices;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int iSize = sizeof(int);
            Console.WriteLine("int형 바이트 길이 : {0}", iSize);

            System.Type myType1 = typeof(int);
            Console.WriteLine("typeof(int) : {0}", myType1);

            int i = 10;
            System.Type myType2 = i.GetType();
            Console.WriteLine("i.GetType() : {0}", myType2);

            System.Type myType3 = typeof(string);
            Console.WriteLine("typeof(int) : {0}", myType3);

            int j = 99;
            float k = 0.1f;
            Console.WriteLine("size of j : {0}", Marshal.SizeOf(k) );
        }
    }
}
