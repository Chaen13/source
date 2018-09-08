using System;


class TypeCastExample1
{
    static void Main(string[] args)
    {
        short a = 10;
        int b = a;
        int c = 50000;
        short d = (short)c;
        Console.WriteLine("short : {0}", d);
        try {
            short e = checked((short)c);
        } catch(Exception e)   {
            Console.WriteLine("예외 : {0}}", e.StackTrace);
        }
    }
}