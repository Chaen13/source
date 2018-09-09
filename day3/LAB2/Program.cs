﻿using System;
namespace LAB2
{
    class Ojc<T>
    {
        private T[] ojcArr = new T[10];
        public T this[int i]
        {
            get { return this.ojcArr[i]; }
            set { this.ojcArr[i] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ojc<string> ojc1 = new Ojc<string>();
            ojc1[0] = "Hello, Ojc";
            System.Console.WriteLine(ojc1[0]);

            Ojc<int> ojc2 = new Ojc<int>();
            ojc2[0] = 999;
            System.Console.WriteLine(ojc2[0]);
        }
    }
}
