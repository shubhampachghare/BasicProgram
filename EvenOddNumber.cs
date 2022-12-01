using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class EvenOddNumber
    {
        public void evenOddNumber()
        {
            int n;
            Console.WriteLine("Enter a number to check : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine(n + " is an even number");
            else
                Console.WriteLine(n + " is an odd number");
        }
    }
}
