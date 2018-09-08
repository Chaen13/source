using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이진수로 변환할 숫자를 입력하세요.");
            int nRead = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            p.ConvertToBin(nRead);
        }

        void ConvertToBin(int nParam)
        {
            string result = "";
            int dum = 0, value = nParam;
            do
            {
                dum = value % 2;
                value = value / 2;
                result = dum + result;
            }
            while (value >= 2);
            result = value + result;

            Console.WriteLine("결과값은 "+result + " 입니다.");
        }
    }
}
