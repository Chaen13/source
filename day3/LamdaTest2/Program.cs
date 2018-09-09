/// <summary>
/// ////////////////////////////////////////////////////////////////
/// 106페이지 예제
/// </summary>
namespace LamdaTest2
{
    delegate bool Onj1();
    delegate bool Onj2(int i);
    class Program
    {
        Onj1 onj1;
        Onj2 onj2;

        public void MyMethod(int input)
        {
            int onjVal = 0;
            onj1 = () => { onjVal = 999; return input > onjVal; };
        }
        static void Main(string[] args)
        {
        }
    }
}

