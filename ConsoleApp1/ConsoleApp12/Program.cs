﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 사칙연산
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두수를 입력하세요.");
            Console.WriteLine("예 : 3, 5");
            string str = Console.ReadLine();
            str.Trim();
            string[] strarr = str.Split(',');

            if(strarr.Length != 2)
            {
                Console.WriteLine("숫자 2개를 콤마로 구분해서 입력하세요.");
            }

            int first, second;
            try
            {
                first = Convert.ToInt32(strarr[0]);
                second = Convert.ToInt32(strarr[1]);
            }
            catch
            {
                Console.WriteLine("입력이 잘못되었습니다.");
                return;
            }

            Console.WriteLine("{0} + {1} = {2}", first, second, Calc(first, second, "+"));
            Console.WriteLine("{0} - {1} = {2}", first, second, Calc(first, second, "-"));
            Console.WriteLine("{0} * {1} = {2}", first, second, Calc(first, second, "*"));
            Console.WriteLine("{0} / {1} = {2}", first, second, Calc(first, second, "/"));
        }

        static double Calc(int nFirst, int nSecond, string sOper)
        {
            double dbResult = 0.0;

            switch( sOper )
            {
                case "+":
                    dbResult = nFirst + nSecond;
                    break;
                case "-":
                    dbResult = nFirst - nSecond;
                    break;
                case "*":
                    dbResult = nFirst * nSecond;
                    break;
                case "/":
                    dbResult = (float)nFirst / (float)nSecond;
                    break;
            }

            return dbResult;
        }
    }
}
