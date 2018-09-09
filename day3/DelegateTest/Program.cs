using System;
namespace DelegateTest
{
    public class Delegate1
    {
        private delegate int OnjSum(int i, int j);
        static void Main(string[] args)
        {
            //Delegate1 de1 = new Delegate1();
            OnjSum myMethod = Delegate1.Sum;    //de1.Sum;
            Console.WriteLine("두수 합 : {0}", myMethod(10, 30));
        }

        static int Sum(int i, int j)
        {
            return i + j;
        }
    }
}
