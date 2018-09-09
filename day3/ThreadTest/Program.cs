using System;
using System.Threading;

namespace threadtest
{
    public class ThreadTest
    {
        public void FirstWork()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.Write("F{0} ", i);
            }
        }

        public void SecondWork()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.Write("S{0} ", i);
            }
        }


        [MTAThread]
        static void Main(string[] args)
        {
            ThreadTest t = new ThreadTest();

            Thread first = new Thread(new ThreadStart(t.FirstWork));
            Thread second = new Thread(new ThreadStart(t.SecondWork));

            first.Start();
            second.Start();

        }
    }
}
