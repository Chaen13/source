using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Exampale
    {
        DayOfWeek _day;
        public DayOfWeek Day
        {
            get
            {
                if (this._day == DayOfWeek.Friday) throw new Exception("Invalid access");
                return this._day;
            }
            set
            {
                this._day = value;
            }
        }
        static void Main(string[] args)
        {
            Exampale example = new Exampale();
            example.Day = DayOfWeek.Monday;
            Console.WriteLine(example.Day);
            Console.WriteLine(example.Day == DayOfWeek.Monday);
        }
    }
}
