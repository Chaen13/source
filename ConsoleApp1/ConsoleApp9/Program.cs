﻿using System;

struct Emp
{
    public int id;
    public string name;
}
class EmpTest
{
    public static void Main(string[] args)
    {
        Emp e;
        e.id = 1;
        e.name = "1깅동";
        Console.WriteLine("사번 : {0}", e.id);
        Console.WriteLine("이름 : {0}", e.name);

        Emp e1 = new Emp(); //new여도 스택에 저장
        e1.id = 2;
        e1.name = "2길동";
        Console.WriteLine("사번 : {0}", e1.id);
        Console.WriteLine("이름 : {0}", e1.name);
    }
}
