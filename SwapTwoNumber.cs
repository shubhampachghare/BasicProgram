using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public  class SwapTwoNumber
    {
        public void swapTwoNumber()
        {
            int a = 26, b = 25;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
