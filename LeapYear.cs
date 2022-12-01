using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public  class LeapYear
    {
        public void leapYear()
        {
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("year is leap year");
            }
            else
            {
                Console.WriteLine("year is not leap year");
            }
            Console.ReadLine();
        }
    }
}
