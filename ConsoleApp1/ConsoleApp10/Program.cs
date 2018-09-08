using System;

class LoopTest
{
    static void Main()
    {
        WhileTest2();
        WhileTest2(1,2,3);
        WhileTest2(1, 2, 3, 4, 5, 6, 7);
        WhileTest2(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        LoopTest b = new LoopTest();
        b.WhileTest();
        b.WhileTest(1,2,3);
        b.WhileTest(1,2,3,4,5,6,7);
        b.WhileTest(new int[]{ 1, 2, 3, 4, 5, 6, 7,8,9,10});

    }
    void WhileTest(params int[] iArr)
    {
        int sum = 0;
        int i = 0;
        if (iArr.Length < 1)
            return;
        do
        {
            sum += iArr[i++];
        }
        while (i < iArr.Length);

        Console.WriteLine("합은 {0}", sum);
    }
    static void WhileTest2(params int[] iArr)
    {
        if (iArr.Length < 1)
            return;

        int sum = 0;
        //for(int i = 0; i < iArr.Length; i++)
        //{
        //    sum += iArr[i];
        //}
        foreach(int i in iArr)
        {
            sum += i;
        }

        Console.WriteLine("합은 {0}", sum);
    }
}