using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class PowerOfTwo
    {
        public  void powerOfTwo()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            double powerOfNumber = Math.Pow(number, 2);
            Console.WriteLine("power of number is" + powerOfNumber);
            Console.ReadLine();
        }
    }
}
