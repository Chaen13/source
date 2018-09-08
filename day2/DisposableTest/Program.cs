using System;

namespace DisposableTest
{
    class Garbage : IDisposable
    {
        private bool isDispose = false;
        private string name;

        public Garbage(string name)
        {
            this.name = name;
            Console.WriteLine("{0}객체 생성됨.. ", name);
        }
        ~Garbage()
        {
            if (!isDispose)
                Dispose();
        }
        public void Dispose()
        {
            isDispose = true;

            Console.WriteLine("{0}객체 리소스 해제.. ", name);
            GC.SuppressFinalize(this);  //소멸자에서 호출 안하도록
        }
    }
    class GarbageTest1
    { 
        static void Main(string[] args)
        {
            Garbage g1 = new Garbage("1번객체");
            Garbage g2 = new Garbage("2번객체");
            Garbage g3 = new Garbage("3번객체");
            Garbage g4 = new Garbage("4번객체");

            g1.Dispose();
            GC.SuppressFinalize(g2);
        }
    }
}
