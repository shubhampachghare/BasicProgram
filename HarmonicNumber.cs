using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public  class HarmonicNumber
    {
        public void harmonicNumber()
        {
            int count, userValue;
            Console.WriteLine("Enter Value Of N:");
            userValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userValue);
            for (count = 1; count <= userValue; count++)
            {
                Console.Write("1/{0} + ", count);
            }
        }
    }
}
