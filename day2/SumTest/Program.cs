using System;

namespace SumTest
{
    class SumTest<T>
    {
        public T Sum(T i, T j)
        {
            return (dynamic)i + (dynamic)j;
        }
    }

    class MinTest
    {
        public T Min<T> (T i, T j)
        {
            return (dynamic)i - (dynamic)j;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            SumTest<int> s = new SumTest<int>();
            Console.WriteLine(s.Sum(1, 2));

            SumTest<float> s2 = new SumTest<float>();
            Console.WriteLine(s2.Sum(1.2f, 2.4f));

            MinTest m = new MinTest();
            Console.WriteLine(m.Min<float>(5.6f, 2.3f));

        }
    }
}
